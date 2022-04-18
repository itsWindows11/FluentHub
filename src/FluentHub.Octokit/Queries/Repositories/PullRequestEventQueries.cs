﻿using FluentHub.Octokit.Models;
using FluentHub.Octokit.Models.Events;
using Humanizer;
using Octokit.GraphQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQLModel = global::Octokit.GraphQL.Model;

namespace FluentHub.Octokit.Queries.Repositories
{
    public class PullRequestEventQueries
    {
        public PullRequestEventQueries() => new App();

        public async Task<List<Tuple<string, object>>> GetAllAsync(string owner, string name, int number)
        {
            #region queries
            var query = new Query()
                .Repository(name, owner)
                .PullRequest(number)
                .Select(x => new
                {
                    TimelineItems = x.TimelineItems(100, null, null, null, null, null, null).Select(x => new
                    {
                        #region AddedToProjectEvent
                        AddedToProjectEvent = x.Nodes.OfType<GraphQLModel.AddedToProjectEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region AssignedEvent
                        AssignedEvent = x.Nodes.OfType<GraphQLModel.AssignedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region AutoMergeDisabledEvent
                        AutoMergeDisabledEvent = x.Nodes.OfType<GraphQLModel.AutoMergeDisabledEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region AutoMergeEnabledEvent
                        AutoMergeEnabledEvent = x.Nodes.OfType<GraphQLModel.AutoMergeEnabledEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region AutoRebaseEnabledEvent
                        AutoRebaseEnabledEvent = x.Nodes.OfType<GraphQLModel.AutoRebaseEnabledEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region AutoSquashEnabledEvent
                        AutoSquashEnabledEvent = x.Nodes.OfType<GraphQLModel.AutoSquashEnabledEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region AutomaticBaseChangeFailedEvent
                        AutomaticBaseChangeFailedEvent = x.Nodes.OfType<GraphQLModel.AutomaticBaseChangeFailedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region AutomaticBaseChangeSucceededEvent
                        AutomaticBaseChangeSucceededEvent = x.Nodes.OfType<GraphQLModel.AutomaticBaseChangeSucceededEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region BaseRefChangedEvent
                        BaseRefChangedEvent = x.Nodes.OfType<GraphQLModel.BaseRefChangedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region BaseRefDeletedEvent
                        BaseRefDeletedEvent = x.Nodes.OfType<GraphQLModel.BaseRefDeletedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region BaseRefForcePushedEvent
                        BaseRefForcePushedEvent = x.Nodes.OfType<GraphQLModel.BaseRefForcePushedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region ClosedEvent
                        ClosedEvent = x.Nodes.OfType<GraphQLModel.ClosedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region CommentDeletedEvent
                        CommentDeletedEvent = x.Nodes.OfType<GraphQLModel.CommentDeletedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region ConnectedEvent
                        ConnectedEvent = x.Nodes.OfType<GraphQLModel.ConnectedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region ConvertedNoteToIssueEvent
                        ConvertedNoteToIssueEvent = x.Nodes.OfType<GraphQLModel.ConvertedNoteToIssueEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region ConvertedToDiscussionEvent (not found)
                        //ConvertedToDiscussionEvent = x.Nodes.OfType<GraphQLModel.ConvertedToDiscussionEvent>().Select(y => new
                        //{
                        //    Actor = y.Actor.Select(actor => new
                        //    {
                        //         AvatarUrl = actor.AvatarUrl(100),
                        //         actor.Login,
                        //    })
                        //    .Single(),
                        //    y.CreatedAt,
                        //})
                        //.ToList(),
                        #endregion

                        #region ConvertToDraftEvent
                        ConvertToDraftEvent = x.Nodes.OfType<GraphQLModel.ConvertToDraftEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region CrossReferencedEvent
                        CrossReferencedEvent = x.Nodes.OfType<GraphQLModel.CrossReferencedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region DemilestonedEvent
                        DemilestonedEvent = x.Nodes.OfType<GraphQLModel.DemilestonedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region DeployedEvent
                        DeployedEvent = x.Nodes.OfType<GraphQLModel.DeployedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region DeploymentEnvernmentChangedEvent (not found)
                        //DeploymentEnvernmentChangedEvent = x.Nodes.OfType<GraphQLModel.DeploymentEnvernmentChangedEvent>().Select(y => new
                        //{
                        //    Actor = y.Actor.Select(actor => new
                        //    {
                        //        AvatarUrl = actor.AvatarUrl(100),
                        //        actor.Login,
                        //    })
                        //    .Single(),
                        //    y.CreatedAt,
                        //})
                        //.ToList(),
                        #endregion

                        #region DisconnectedEvent
                        DisconnectedEvent = x.Nodes.OfType<GraphQLModel.DisconnectedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region HeadRefDeletedEvent
                        HeadRefDeletedEvent = x.Nodes.OfType<GraphQLModel.HeadRefDeletedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                              .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region HeadRefForcePushedEvent
                        HeadRefForcePushedEvent = x.Nodes.OfType<GraphQLModel.HeadRefForcePushedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                              .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region HeadRefRestoredEvent
                        HeadRefRestoredEvent = x.Nodes.OfType<GraphQLModel.HeadRefRestoredEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                              .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region IssueComment
                        IssueComment = x.Nodes.OfType<GraphQLModel.IssueComment>().Select(y => new
                        {
                            Author = y.Author.Select(author => new
                            {
                                AvatarUrl = author.AvatarUrl(100),
                                author.Login,
                            })
                            .Single(),

                            y.AuthorAssociation,
                            y.BodyHTML,
                            y.MinimizedReason,
                            y.Url,

                            Reactions = y.Reactions(6, null, null, null, null, null).Nodes.Select(reaction => new
                            {
                                Reactions = reaction.Select(reactionNode => new {
                                    reactionNode.Content,
                                    ReactedUserName = reactionNode.User.Login,
                                })
                                .Single(),
                            })
                            .ToList(),

                            y.IsMinimized,
                            y.ViewerCanDelete,
                            y.ViewerCanMinimize,
                            y.ViewerCanReact,
                            y.ViewerCanUpdate,
                            y.ViewerDidAuthor,

                            y.LastEditedAt,
                            y.CreatedAt,
                            y.UpdatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region LabeledEvent
                        LabeledEvent = x.Nodes.OfType<GraphQLModel.LabeledEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                            .Single(),

                            y.Label.Color,
                            y.Label.Name,

                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region LockedEvent
                        LockedEvent = x.Nodes.OfType<GraphQLModel.LockedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                actor.Login,
                                AvatarUrl = actor.AvatarUrl(100),
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region MarkedAsDuplicateEvent
                        MarkedAsDuplicateEvent = x.Nodes.OfType<GraphQLModel.MarkedAsDuplicateEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                actor.Login,
                                AvatarUrl = actor.AvatarUrl(100),
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region MentionedEvent
                        MentionedEvent = x.Nodes.OfType<GraphQLModel.MentionedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                actor.Login,
                                AvatarUrl = actor.AvatarUrl(100),
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region MergedEvent
                        MergedEvent = x.Nodes.OfType<GraphQLModel.MergedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                              .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region MilestonedEvent
                        MilestonedEvent = x.Nodes.OfType<GraphQLModel.MilestonedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                actor.Login,
                                AvatarUrl = actor.AvatarUrl(100),
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region MovedColumnsInProjectEvent
                        MovedColumnsInProjectEvent = x.Nodes.OfType<GraphQLModel.MovedColumnsInProjectEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                actor.Login,
                                AvatarUrl = actor.AvatarUrl(100),
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region PinnedEvent
                        PinnedEvent = x.Nodes.OfType<GraphQLModel.PinnedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                actor.Login,
                                AvatarUrl = actor.AvatarUrl(100),
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region PullRequestCommit
                        PullRequestCommit = x.Nodes.OfType<GraphQLModel.PullRequestCommit>().Select(y => new
                        {
                            Actor = y.Commit.Author.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                Login = actor.Name,
                            })
                            .Single(),
                            CreatedAt = y.Commit.PushedDate,
                        })
                        .ToList(),
                        #endregion

                        #region PullRequestCommitCommentThread
                        PullRequestCommitCommentThread = x.Nodes.OfType<GraphQLModel.PullRequestCommitCommentThread>().Select(y => new
                        {
                            Actor = y.Commit.Author.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                Login = actor.Name,
                            })
                            .Single(),
                            CreatedAt = y.Commit.PushedDate,
                        })
                        .ToList(),
                        #endregion

                        #region PullRequestReview
                        PullRequestReview = x.Nodes.OfType<GraphQLModel.PullRequestReview>().Select(y => new
                        {
                            Actor = y.Commit.Author.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                Login = actor.Name,
                            })
                            .Single(),
                            CreatedAt = y.Commit.PushedDate,
                        })
                        .ToList(),
                        #endregion

                        #region PullRequestReviewComment
                        PullRequestReviewComment = x.Nodes.OfType<GraphQLModel.PullRequestReviewComment>().Select(y => new
                        {
                            Actor = y.Commit.Author.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                Login = actor.Name,
                            })
                            .Single(),
                            CreatedAt = y.Commit.PushedDate,
                        })
                        .ToList(),
                        #endregion

                        #region PullRequestReviewThread
                        PullRequestReviewThread = x.Nodes.OfType<GraphQLModel.PullRequestReviewThread>().Select(y => new
                        {
                            Actor = y.PullRequest.Author.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                Login = actor.Login,
                            })
                            .Single(),
                            y.PullRequest.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region PullRequestRevisionMarker
                        PullRequestRevisionMarker = x.Nodes.OfType<GraphQLModel.PullRequestRevisionMarker>().Select(y => new
                        {
                            Actor = y.LastSeenCommit.Author.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                Login = actor.Name,
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region ReadyForReviewEvent
                        ReadyForReviewEvent = x.Nodes.OfType<GraphQLModel.ReadyForReviewEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                              .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region ReferencedEvent
                        ReferencedEvent = x.Nodes.OfType<GraphQLModel.ReferencedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                actor.Login,
                                AvatarUrl = actor.AvatarUrl(100),
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region RemovedFromProjectEvent
                        RemovedFromProjectEvent = x.Nodes.OfType<GraphQLModel.RemovedFromProjectEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                actor.Login,
                                AvatarUrl = actor.AvatarUrl(100),
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region RenamedTitleEvent
                        RenamedTitleEvent = x.Nodes.OfType<GraphQLModel.RenamedTitleEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                actor.Login,
                                AvatarUrl = actor.AvatarUrl(100),
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region ReopenedEvent
                        ReopenedEvent = x.Nodes.OfType<GraphQLModel.ReopenedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                actor.Login,
                                AvatarUrl = actor.AvatarUrl(100),
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region ReviewDismissedEvent
                        ReviewDismissedEvent = x.Nodes.OfType<GraphQLModel.ReviewDismissedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                              .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region ReviewRequestedEvent
                        ReviewRequestedEvent = x.Nodes.OfType<GraphQLModel.ReviewRequestedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                              .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region ReviewRequestRemovedEvent
                        ReviewRequestRemovedEvent = x.Nodes.OfType<GraphQLModel.ReviewRequestRemovedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                              .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region SubscribedEvent
                        SubscribedEvent = x.Nodes.OfType<GraphQLModel.SubscribedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                actor.Login,
                                AvatarUrl = actor.AvatarUrl(100),
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region TransferredEvent
                        TransferredEvent = x.Nodes.OfType<GraphQLModel.TransferredEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                AvatarUrl = actor.AvatarUrl(100),
                                actor.Login,
                            })
                              .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region UnassignedEvent
                        UnassignedEvent = x.Nodes.OfType<GraphQLModel.UnassignedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                actor.Login,
                                AvatarUrl = actor.AvatarUrl(100),
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region UnlabeledEvent
                        UnlabeledEvent = x.Nodes.OfType<GraphQLModel.UnlabeledEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                actor.Login,
                                AvatarUrl = actor.AvatarUrl(100),
                            })
                            .Single(),

                            y.Label.Color,
                            y.Label.Name,

                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region UnlockedEvent
                        UnlockedEvent = x.Nodes.OfType<GraphQLModel.UnlockedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                actor.Login,
                                AvatarUrl = actor.AvatarUrl(100),
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region UnmarkedAsDuplicateEvent
                        UnmarkedAsDuplicateEvent = x.Nodes.OfType<GraphQLModel.UnmarkedAsDuplicateEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                actor.Login,
                                AvatarUrl = actor.AvatarUrl(100),
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region UnpinnedEvent
                        UnpinnedEvent = x.Nodes.OfType<GraphQLModel.UnpinnedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                actor.Login,
                                AvatarUrl = actor.AvatarUrl(100),
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region UnsubscribedEvent
                        UnsubscribedEvent = x.Nodes.OfType<GraphQLModel.UnsubscribedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                actor.Login,
                                AvatarUrl = actor.AvatarUrl(100),
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion

                        #region UserBlockedEvent
                        UserBlockedEvent = x.Nodes.OfType<GraphQLModel.UserBlockedEvent>().Select(y => new
                        {
                            Actor = y.Actor.Select(actor => new
                            {
                                actor.Login,
                                AvatarUrl = actor.AvatarUrl(100),
                            })
                            .Single(),
                            y.CreatedAt,
                        })
                        .ToList(),
                        #endregion
                    })
                    .SingleOrDefault(),
                })
                .Compile();
            #endregion

            var response = await App.Connection.Run(query);

            List<Tuple<string, object>> allEvents = new();
            List<Tuple<string, int, DateTimeOffset>> allEventCreatedDates = new();

            #region copying
            List<AddedToProjectEvent> addedToProjectEvents = new();
            foreach (var item in response.TimelineItems.AddedToProjectEvent)
            {
                AddedToProjectEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                addedToProjectEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(AddedToProjectEvent), addedToProjectEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<AssignedEvent> assignedEvents = new();
            foreach (var item in response.TimelineItems.AssignedEvent)
            {
                AssignedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                assignedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(AssignedEvent), assignedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<AutoMergeDisabledEvent> autoMergeDisabledEvents = new();
            foreach (var item in response.TimelineItems.AutoMergeDisabledEvent)
            {
                AutoMergeDisabledEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                autoMergeDisabledEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(AutoMergeDisabledEvent), autoMergeDisabledEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<AutoMergeEnabledEvent> autoMergeEnabledEvents = new();
            foreach (var item in response.TimelineItems.AutoMergeEnabledEvent)
            {
                AutoMergeEnabledEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                autoMergeEnabledEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(AutoMergeEnabledEvent), autoMergeEnabledEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<AutoRebaseEnabledEvent> autoRebaseEnabledEvents = new();
            foreach (var item in response.TimelineItems.AutoRebaseEnabledEvent)
            {
                AutoRebaseEnabledEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                autoRebaseEnabledEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(AutoRebaseEnabledEvent), autoRebaseEnabledEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<AutoSquashEnabledEvent> autoSquashEnabledEvents = new();
            foreach (var item in response.TimelineItems.AutoSquashEnabledEvent)
            {
                AutoSquashEnabledEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                autoSquashEnabledEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(AutoSquashEnabledEvent), autoSquashEnabledEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<AutomaticBaseChangeFailedEvent> automaticBaseChangeFailedEvents = new();
            foreach (var item in response.TimelineItems.AutomaticBaseChangeFailedEvent)
            {
                AutomaticBaseChangeFailedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                automaticBaseChangeFailedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(AutomaticBaseChangeFailedEvent), automaticBaseChangeFailedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<AutomaticBaseChangeSucceededEvent> automaticBaseChangeSucceededEvents = new();
            foreach (var item in response.TimelineItems.AutomaticBaseChangeSucceededEvent)
            {
                AutomaticBaseChangeSucceededEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                automaticBaseChangeSucceededEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(AutomaticBaseChangeSucceededEvent), automaticBaseChangeSucceededEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<BaseRefChangedEvent> baseRefChangedEvents = new();
            foreach (var item in response.TimelineItems.BaseRefChangedEvent)
            {
                BaseRefChangedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                baseRefChangedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(BaseRefChangedEvent), baseRefChangedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<BaseRefDeletedEvent> baseRefDeletedEvents = new();
            foreach (var item in response.TimelineItems.BaseRefDeletedEvent)
            {
                BaseRefDeletedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                baseRefDeletedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(BaseRefDeletedEvent), baseRefDeletedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<BaseRefForcePushedEvent> baseRefForcePushedEvents = new();
            foreach (var item in response.TimelineItems.BaseRefForcePushedEvent)
            {
                BaseRefForcePushedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                baseRefForcePushedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(BaseRefForcePushedEvent), baseRefForcePushedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<ClosedEvent> closedEvents = new();
            foreach (var item in response.TimelineItems.ClosedEvent)
            {
                ClosedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                closedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(ClosedEvent), closedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<CommentDeletedEvent> commentDeletedEvents = new();
            foreach (var item in response.TimelineItems.CommentDeletedEvent)
            {
                CommentDeletedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                commentDeletedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(CommentDeletedEvent), commentDeletedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<ConnectedEvent> connectedEvents = new();
            foreach (var item in response.TimelineItems.ConnectedEvent)
            {
                ConnectedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                connectedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(ConnectedEvent), connectedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<ConvertedNoteToIssueEvent> convertedNoteToIssueEvents = new();
            foreach (var item in response.TimelineItems.ConvertedNoteToIssueEvent)
            {
                ConvertedNoteToIssueEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                convertedNoteToIssueEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(ConvertedNoteToIssueEvent), convertedNoteToIssueEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<ConvertToDraftEvent> convertToDraftEvents = new();
            foreach (var item in response.TimelineItems.ConvertToDraftEvent)
            {
                ConvertToDraftEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                convertToDraftEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(ConvertToDraftEvent), convertToDraftEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<CrossReferencedEvent> crossReferencedEvents = new();
            foreach (var item in response.TimelineItems.CrossReferencedEvent)
            {
                CrossReferencedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                crossReferencedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(CrossReferencedEvent), crossReferencedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<DemilestonedEvent> demilestonedEvents = new();
            foreach (var item in response.TimelineItems.DemilestonedEvent)
            {
                DemilestonedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                demilestonedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(DemilestonedEvent), demilestonedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<DeployedEvent> deployedEvents = new();
            foreach (var item in response.TimelineItems.DeployedEvent)
            {
                DeployedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                deployedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(DeployedEvent), deployedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<DisconnectedEvent> disconnectedEvents = new();
            foreach (var item in response.TimelineItems.DisconnectedEvent)
            {
                DisconnectedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                disconnectedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(DisconnectedEvent), disconnectedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<HeadRefDeletedEvent> headRefDeletedEvents = new();
            foreach (var item in response.TimelineItems.HeadRefDeletedEvent)
            {
                HeadRefDeletedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                headRefDeletedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(HeadRefDeletedEvent), headRefDeletedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<HeadRefForcePushedEvent> headRefForcePushedEvents = new();
            foreach (var item in response.TimelineItems.HeadRefForcePushedEvent)
            {
                HeadRefForcePushedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                headRefForcePushedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(HeadRefForcePushedEvent), headRefForcePushedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<HeadRefRestoredEvent> headRefRestoredEvents = new();
            foreach (var item in response.TimelineItems.HeadRefRestoredEvent)
            {
                HeadRefRestoredEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                headRefRestoredEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(HeadRefRestoredEvent), headRefRestoredEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<IssueComment> issueComments = new();
            foreach (var item in response.TimelineItems.IssueComment)
            {
                IssueComment indivisual = new()
                {
                    AuthorAvatarUrl = item.Author.AvatarUrl,
                    AuthorLogin = item.Author.Login,
                    BodyHtml = item.BodyHTML,
                    MinimizedReason = item.MinimizedReason,
                    Url = item.Url,

                    IsEdited = item.LastEditedAt == null ? false : true,
                    IsMinimized = item.IsMinimized,
                    ViewerCanDelete = item.ViewerCanDelete,
                    ViewerCanMinimize = item.ViewerCanMinimize,
                    ViewerCanReact = item.ViewerCanReact,
                    ViewerCanUpdate = item.ViewerCanUpdate,
                    ViewerDidAuthor = item.ViewerDidAuthor,

                    AuthorAssociation = item.AuthorAssociation,

                    UpdatedAt = item.UpdatedAt,
                    CreatedAt = item.CreatedAt,
                };

                foreach (var reaction in item.Reactions)
                {
                    switch (reaction.Reactions.Content)
                    {
                        case GraphQLModel.ReactionContent.ThumbsUp:
                            indivisual.Reactions.ThumbsUpCount++;
                            indivisual.Reactions.ThumbsUpActors.Add(reaction.Reactions.ReactedUserName);
                            if (reaction.Reactions.ReactedUserName == App.SignedInUserName)
                                indivisual.Reactions.ViewerReactThumbsUp = true;
                            break;
                        case GraphQLModel.ReactionContent.ThumbsDown:
                            indivisual.Reactions.ThumbsDownCount++;
                            indivisual.Reactions.ThumbsDownActors.Add(reaction.Reactions.ReactedUserName);
                            if (reaction.Reactions.ReactedUserName == App.SignedInUserName)
                                indivisual.Reactions.ViewerReactThumbsDown = true;
                            break;
                        case GraphQLModel.ReactionContent.Laugh:
                            indivisual.Reactions.LaughCount++;
                            indivisual.Reactions.LaughActors.Add(reaction.Reactions.ReactedUserName);
                            if (reaction.Reactions.ReactedUserName == App.SignedInUserName)
                                indivisual.Reactions.ViewerReactLaugh = true;
                            break;
                        case GraphQLModel.ReactionContent.Hooray:
                            indivisual.Reactions.HoorayCount++;
                            indivisual.Reactions.HoorayActors.Add(reaction.Reactions.ReactedUserName);
                            if (reaction.Reactions.ReactedUserName == App.SignedInUserName)
                                indivisual.Reactions.ViewerReactHooray = true;
                            break;
                        case GraphQLModel.ReactionContent.Confused:
                            indivisual.Reactions.ConfusedCount++;
                            indivisual.Reactions.ConfusedActors.Add(reaction.Reactions.ReactedUserName);
                            if (reaction.Reactions.ReactedUserName == App.SignedInUserName)
                                indivisual.Reactions.ViewerReactConfused = true;
                            break;
                        case GraphQLModel.ReactionContent.Heart:
                            indivisual.Reactions.HeartCount++;
                            indivisual.Reactions.HeartActors.Add(reaction.Reactions.ReactedUserName);
                            if (reaction.Reactions.ReactedUserName == App.SignedInUserName)
                                indivisual.Reactions.ViewerReactHeart = true;
                            break;
                        case GraphQLModel.ReactionContent.Rocket:
                            indivisual.Reactions.RocketCount++;
                            indivisual.Reactions.RocketActors.Add(reaction.Reactions.ReactedUserName);
                            if (reaction.Reactions.ReactedUserName == App.SignedInUserName)
                                indivisual.Reactions.ViewerReactRocket = true;
                            break;
                        case GraphQLModel.ReactionContent.Eyes:
                            indivisual.Reactions.EyesCount++;
                            indivisual.Reactions.EyesActors.Add(reaction.Reactions.ReactedUserName);
                            if (reaction.Reactions.ReactedUserName == App.SignedInUserName)
                                indivisual.Reactions.ViewerReactEyes = true;
                            break;
                    }
                }

                issueComments.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(IssueComment), issueComments.Count() - 1, indivisual.CreatedAt));
            }

            List<LabeledEvent> labeledEvents = new();
            foreach (var item in response.TimelineItems.LabeledEvent)
            {
                LabeledEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,

                    LabeledLabel = new()
                    {
                        Color = item.Color,
                        ColorBrush = Helpers.ColorHelper.HexCodeToSolidColorBrush(item.Color),
                        Name = item.Name,
                    },

                    CreatedAt = item.CreatedAt,
                    CreatedAtHumanized = item.CreatedAt.Humanize(),
                };

                labeledEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(LabeledEvent), labeledEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<LockedEvent> lockedEvents = new();
            foreach (var item in response.TimelineItems.LockedEvent)
            {
                LockedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                lockedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(LockedEvent), lockedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<MarkedAsDuplicateEvent> markedAsDuplicateEvents = new();
            foreach (var item in response.TimelineItems.MarkedAsDuplicateEvent)
            {
                MarkedAsDuplicateEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                markedAsDuplicateEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(MarkedAsDuplicateEvent), markedAsDuplicateEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<MentionedEvent> mentionedEvents = new();
            foreach (var item in response.TimelineItems.MentionedEvent)
            {
                MentionedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                mentionedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(MentionedEvent), mentionedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<MergedEvent> mergedEvents = new();
            foreach (var item in response.TimelineItems.MergedEvent)
            {
                MergedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                mergedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(MergedEvent), mergedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<MilestonedEvent> milestonedEvents = new();
            foreach (var item in response.TimelineItems.MilestonedEvent)
            {
                MilestonedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                milestonedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(MilestonedEvent), milestonedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<MovedColumnsInProjectEvent> movedColumnsInProjectEvents = new();
            foreach (var item in response.TimelineItems.MovedColumnsInProjectEvent)
            {
                MovedColumnsInProjectEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                movedColumnsInProjectEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(MovedColumnsInProjectEvent), movedColumnsInProjectEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<PinnedEvent> pinnedEvents = new();
            foreach (var item in response.TimelineItems.PinnedEvent)
            {
                PinnedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                pinnedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(PinnedEvent), pinnedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<PullRequestCommit> pullRequestCommits = new();
            foreach (var item in response.TimelineItems.PullRequestCommit)
            {
                PullRequestCommit indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = (DateTimeOffset)item.CreatedAt,
                };

                pullRequestCommits.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(PullRequestCommit), pullRequestCommits.Count() - 1, indivisual.CreatedAt));
            }

            List<PullRequestCommitCommentThread> pullRequestCommitCommentThreads = new();
            foreach (var item in response.TimelineItems.PullRequestCommitCommentThread)
            {
                PullRequestCommitCommentThread indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = (DateTimeOffset)item.CreatedAt,
                };

                pullRequestCommitCommentThreads.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(PullRequestCommitCommentThread), pullRequestCommitCommentThreads.Count() - 1, indivisual.CreatedAt));
            }

            List<PullRequestReview> pullRequestReviews = new();
            foreach (var item in response.TimelineItems.PullRequestReview)
            {
                PullRequestReview indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = (DateTimeOffset)item.CreatedAt,
                };

                pullRequestReviews.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(PullRequestReview), pullRequestReviews.Count() - 1, indivisual.CreatedAt));
            }

            List<PullRequestReviewThread> pullRequestReviewThreads = new();
            foreach (var item in response.TimelineItems.PullRequestReviewThread)
            {
                PullRequestReviewThread indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                pullRequestReviewThreads.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(PullRequestReviewThread), pullRequestReviewThreads.Count() - 1, indivisual.CreatedAt));
            }

            List<PullRequestRevisionMarker> pullRequestRevisionMarkers = new();
            foreach (var item in response.TimelineItems.PullRequestRevisionMarker)
            {
                PullRequestRevisionMarker indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                pullRequestRevisionMarkers.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(PullRequestRevisionMarker), pullRequestRevisionMarkers.Count() - 1, indivisual.CreatedAt));
            }

            List<ReadyForReviewEvent> readyForReviewEvents = new();
            foreach (var item in response.TimelineItems.ReadyForReviewEvent)
            {
                ReadyForReviewEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                readyForReviewEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(ReadyForReviewEvent), readyForReviewEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<ReferencedEvent> referencedEvents = new();
            foreach (var item in response.TimelineItems.ReferencedEvent)
            {
                ReferencedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                referencedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(ReferencedEvent), referencedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<RemovedFromProjectEvent> removedFromProjectEvents = new();
            foreach (var item in response.TimelineItems.RemovedFromProjectEvent)
            {
                RemovedFromProjectEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                removedFromProjectEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(RemovedFromProjectEvent), removedFromProjectEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<RenamedTitleEvent> renamedTitleEvents = new();
            foreach (var item in response.TimelineItems.RenamedTitleEvent)
            {
                RenamedTitleEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                renamedTitleEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(RenamedTitleEvent), renamedTitleEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<ReopenedEvent> reopenedEvents = new();
            foreach (var item in response.TimelineItems.ReopenedEvent)
            {
                ReopenedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                reopenedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(ReopenedEvent), reopenedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<ReviewDismissedEvent> reviewDismissedEvents = new();
            foreach (var item in response.TimelineItems.ReviewDismissedEvent)
            {
                ReviewDismissedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                reviewDismissedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(ReviewDismissedEvent), reviewDismissedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<ReviewRequestedEvent> reviewRequestedEvents = new();
            foreach (var item in response.TimelineItems.ReviewRequestedEvent)
            {
                ReviewRequestedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                reviewRequestedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(ReviewRequestedEvent), reviewRequestedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<ReviewRequestRemovedEvent> reviewRequestRemovedEvents = new();
            foreach (var item in response.TimelineItems.ReviewRequestRemovedEvent)
            {
                ReviewRequestRemovedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                reviewRequestRemovedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(ReviewRequestRemovedEvent), reviewRequestRemovedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<SubscribedEvent> subscribedEvents = new();
            foreach (var item in response.TimelineItems.SubscribedEvent)
            {
                SubscribedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                subscribedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(SubscribedEvent), subscribedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<TransferredEvent> transferredEvents = new();
            foreach (var item in response.TimelineItems.TransferredEvent)
            {
                TransferredEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                transferredEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(TransferredEvent), transferredEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<UnassignedEvent> unassignedEvents = new();
            foreach (var item in response.TimelineItems.UnassignedEvent)
            {
                UnassignedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                unassignedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(UnassignedEvent), unassignedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<UnlabeledEvent> unlabeledEvents = new();
            foreach (var item in response.TimelineItems.UnlabeledEvent)
            {
                UnlabeledEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,

                    UnlabeledLabel = new()
                    {
                        Color = item.Color,
                        ColorBrush = Helpers.ColorHelper.HexCodeToSolidColorBrush(item.Color),
                        Name = item.Name,
                    },

                    CreatedAt = item.CreatedAt,
                    CreatedAtHumanized = item.CreatedAt.Humanize(),
                };

                unlabeledEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(UnlabeledEvent), unlabeledEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<UnlockedEvent> unlockedEvents = new();
            foreach (var item in response.TimelineItems.UnlockedEvent)
            {
                UnlockedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                unlockedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(UnlockedEvent), unlockedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<UnmarkedAsDuplicateEvent> unmarkedAsDuplicateEvents = new();
            foreach (var item in response.TimelineItems.UnmarkedAsDuplicateEvent)
            {
                UnmarkedAsDuplicateEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                unmarkedAsDuplicateEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(UnmarkedAsDuplicateEvent), unmarkedAsDuplicateEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<UnpinnedEvent> unpinnedEvents = new();
            foreach (var item in response.TimelineItems.UnpinnedEvent)
            {
                UnpinnedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                unpinnedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(UnpinnedEvent), unpinnedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<UnsubscribedEvent> unsubscribedEvents = new();
            foreach (var item in response.TimelineItems.UnsubscribedEvent)
            {
                UnsubscribedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                unsubscribedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(UnsubscribedEvent), unsubscribedEvents.Count() - 1, indivisual.CreatedAt));
            }

            List<UserBlockedEvent> userBlockedEvents = new();
            foreach (var item in response.TimelineItems.UserBlockedEvent)
            {
                UserBlockedEvent indivisual = new()
                {
                    ActorAvatarUrl = item.Actor.AvatarUrl,
                    ActorLogin = item.Actor.Login,
                    CreatedAt = item.CreatedAt,
                };

                userBlockedEvents.Add(indivisual);
                allEventCreatedDates.Add(Tuple.Create(nameof(UserBlockedEvent), userBlockedEvents.Count() - 1, indivisual.CreatedAt));
            }
            #endregion

            // Sort by dates
            foreach (var item in allEventCreatedDates.OrderBy(x => x.Item3).ToList())
            {
                switch (item.Item1)
                {
                    case "AddedToProjectEvent":
                        allEvents.Add(Tuple.Create(item.Item1, addedToProjectEvents[item.Item2] as object));
                        break;
                    case "AssignedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, assignedEvents[item.Item2] as object));
                        break;
                    case "AutoMergeDisabledEvent":
                        allEvents.Add(Tuple.Create(item.Item1, autoMergeDisabledEvents[item.Item2] as object));
                        break;
                    case "AutoMergeEnabledEvent":
                        allEvents.Add(Tuple.Create(item.Item1, autoMergeEnabledEvents[item.Item2] as object));
                        break;
                    case "AutoRebaseEnabledEvent":
                        allEvents.Add(Tuple.Create(item.Item1, autoRebaseEnabledEvents[item.Item2] as object));
                        break;
                    case "AutoSquashEnabledEvent":
                        allEvents.Add(Tuple.Create(item.Item1, autoSquashEnabledEvents[item.Item2] as object));
                        break;
                    case "AutomaticBaseChangeFailedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, automaticBaseChangeFailedEvents[item.Item2] as object));
                        break;
                    case "AutomaticBaseChangeSucceededEvent":
                        allEvents.Add(Tuple.Create(item.Item1, automaticBaseChangeSucceededEvents[item.Item2] as object));
                        break;
                    case "BaseRefChangedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, baseRefChangedEvents[item.Item2] as object));
                        break;
                    case "BaseRefDeletedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, baseRefDeletedEvents[item.Item2] as object));
                        break;
                    case "BaseRefForcePushedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, baseRefForcePushedEvents[item.Item2] as object));
                        break;
                    case "ClosedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, closedEvents[item.Item2] as object));
                        break;
                    case "CommentDeletedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, commentDeletedEvents[item.Item2] as object));
                        break;
                    case "ConnectedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, connectedEvents[item.Item2] as object));
                        break;
                    case "ConvertedNoteToIssueEvent":
                        allEvents.Add(Tuple.Create(item.Item1, convertedNoteToIssueEvents[item.Item2] as object));
                        break;
                    case "ConvertToDraftEvent":
                        allEvents.Add(Tuple.Create(item.Item1, convertToDraftEvents[item.Item2] as object));
                        break;
                    case "CrossReferencedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, crossReferencedEvents[item.Item2] as object));
                        break;
                    case "DemilestonedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, demilestonedEvents[item.Item2] as object));
                        break;
                    case "DeployedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, deployedEvents[item.Item2] as object));
                        break;
                    case "DisconnectedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, disconnectedEvents[item.Item2] as object));
                        break;
                    case "HeadRefDeletedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, headRefDeletedEvents[item.Item2] as object));
                        break;
                    case "HeadRefForcePushedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, headRefForcePushedEvents[item.Item2] as object));
                        break;
                    case "HeadRefRestoredEvent":
                        allEvents.Add(Tuple.Create(item.Item1, headRefRestoredEvents[item.Item2] as object));
                        break;
                    case "IssueComment":
                        allEvents.Add(Tuple.Create(item.Item1, issueComments[item.Item2] as object));
                        break;
                    case "LabeledEvent":
                        allEvents.Add(Tuple.Create(item.Item1, labeledEvents[item.Item2] as object));
                        break;
                    case "LockedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, lockedEvents[item.Item2] as object));
                        break;
                    case "MarkedAsDuplicateEvent":
                        allEvents.Add(Tuple.Create(item.Item1, markedAsDuplicateEvents[item.Item2] as object));
                        break;
                    case "MentionedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, mentionedEvents[item.Item2] as object));
                        break;
                    case "MergedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, mergedEvents[item.Item2] as object));
                        break;
                    case "MilestonedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, milestonedEvents[item.Item2] as object));
                        break;
                    case "MovedColumnsInProjectEvent":
                        allEvents.Add(Tuple.Create(item.Item1, movedColumnsInProjectEvents[item.Item2] as object));
                        break;
                    case "PinnedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, pinnedEvents[item.Item2] as object));
                        break;
                    case "RullRequestCommit":
                        allEvents.Add(Tuple.Create(item.Item1, pullRequestCommits[item.Item2] as object));
                        break;
                    case "RullRequestCommitCommentThread":
                        allEvents.Add(Tuple.Create(item.Item1, pullRequestCommitCommentThreads[item.Item2] as object));
                        break;
                    case "RullRequestReview":
                        allEvents.Add(Tuple.Create(item.Item1, pullRequestReviews[item.Item2] as object));
                        break;
                    case "RullRequestReviewThread":
                        allEvents.Add(Tuple.Create(item.Item1, pullRequestReviewThreads[item.Item2] as object));
                        break;
                    case "RullRequestRevisionMarker":
                        allEvents.Add(Tuple.Create(item.Item1, pullRequestRevisionMarkers[item.Item2] as object));
                        break;
                    case "ReadyForReviewEvent":
                        allEvents.Add(Tuple.Create(item.Item1, readyForReviewEvents[item.Item2] as object));
                        break;
                    case "ReferencedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, referencedEvents[item.Item2] as object));
                        break;
                    case "RemovedFromProjectEvent":
                        allEvents.Add(Tuple.Create(item.Item1, removedFromProjectEvents[item.Item2] as object));
                        break;
                    case "RenamedTitleEvent":
                        allEvents.Add(Tuple.Create(item.Item1, renamedTitleEvents[item.Item2] as object));
                        break;
                    case "ReopenedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, reopenedEvents[item.Item2] as object));
                        break;
                    case "ReviewDismissedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, reviewDismissedEvents[item.Item2] as object));
                        break;
                    case "ReviewRequestedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, reviewRequestedEvents[item.Item2] as object));
                        break;
                    case "ReviewRequestRemovedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, reviewRequestRemovedEvents[item.Item2] as object));
                        break;
                    case "SubscribedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, subscribedEvents[item.Item2] as object));
                        break;
                    case "TransferredEvent":
                        allEvents.Add(Tuple.Create(item.Item1, transferredEvents[item.Item2] as object));
                        break;
                    case "UnassignedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, unassignedEvents[item.Item2] as object));
                        break;
                    case "UnlabeledEvent":
                        allEvents.Add(Tuple.Create(item.Item1, unlabeledEvents[item.Item2] as object));
                        break;
                    case "UnlockedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, unlockedEvents[item.Item2] as object));
                        break;
                    case "UnmarkedAsDuplicateEvent":
                        allEvents.Add(Tuple.Create(item.Item1, unmarkedAsDuplicateEvents[item.Item2] as object));
                        break;
                    case "UnpinnedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, unpinnedEvents[item.Item2] as object));
                        break;
                    case "UnsubscribedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, unsubscribedEvents[item.Item2] as object));
                        break;
                    case "UserBlockedEvent":
                        allEvents.Add(Tuple.Create(item.Item1, userBlockedEvents[item.Item2] as object));
                        break;
                }
            }

            return allEvents;
        }
    }
}