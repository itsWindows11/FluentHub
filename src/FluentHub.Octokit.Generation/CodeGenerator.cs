﻿using System;
using System.Collections.Generic;
using System.IO;
using FluentHub.Octokit.Generation.Models;
using Octokit.GraphQL.Core.Introspection;

namespace FluentHub.Octokit.Generation
{
    public static class CodeGenerator
    {
        public static IEnumerable<GeneratedFile> Generate(SchemaModel schema, string rootNamespace, string entityNamespace = null)
        {
            foreach (var type in schema.Types)
            {
                if (!type.Name.StartsWith("__") && type.Kind != TypeKind.Scalar)
                {
                    yield return Generate(type, rootNamespace, schema.QueryType,  entityNamespace);
                }
            }
        }

        public static GeneratedFile Generate(TypeModel type, string rootNamespace, string queryType, string entityNamespace = null)
        {
            entityNamespace = entityNamespace ?? rootNamespace;

            string result = null;
            switch (type.Kind)
            {
                case TypeKind.Object:
                    if (type.Name == queryType || type.Name == "Mutation")
                    {
                        // Mutation.cs and Query.cs is not needed
                    }
                    else
                    {
                        result = EntityGenerator.Generate(type, entityNamespace, queryType, entityNamespace: entityNamespace);
                    }
                    break;

                case TypeKind.Interface:
                    result = InterfaceGenerator.Generate(type, entityNamespace, queryType);
                    break;

                case TypeKind.Enum:
                    result = EnumGenerator.Generate(type, entityNamespace);
                    break;

                case TypeKind.InputObject:
                    result = InputObjectGenerator.Generate(type, entityNamespace);
                    break;

                case TypeKind.Union:
                    result = UnionGenerator.Generate(type, entityNamespace);
                    break;
            }

            var fileName = type.Name + ".cs";
            return new GeneratedFile(fileName, result);
        }
    }
}
