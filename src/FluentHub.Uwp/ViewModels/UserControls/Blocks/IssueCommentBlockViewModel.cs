﻿using FluentHub.Uwp.Helpers;
using FluentHub.Uwp.Services;
using FluentHub.Uwp.ViewModels.UserControls.Labels;
using Windows.UI.Xaml.Controls;

namespace FluentHub.Uwp.ViewModels.UserControls.Blocks
{
    public class IssueCommentBlockViewModel : ObservableObject
    {
        public IssueCommentBlockViewModel()
        {
            IsEditedLabel = new()
            {
                Color = "#36000000",
                Name = "Edited",
            };

            AuthorAssociationLabel = new()
            {
                Color = "#36000000",
            };
        }

        #region Fields and Properties
        private IssueComment issueComment;
        public IssueComment IssueComment { get => issueComment; set => SetProperty(ref issueComment, value); }

        private string createdAtHumanized;
        public string CreatedAtHumanized { get => createdAtHumanized; set => SetProperty(ref createdAtHumanized, value); }

        private LabelControlViewModel _isEditedLabel;
        public LabelControlViewModel IsEditedLabel { get => _isEditedLabel; set => SetProperty(ref _isEditedLabel, value); }

        private LabelControlViewModel _authorAssociationLabel;
        public LabelControlViewModel AuthorAssociationLabel { get => _authorAssociationLabel; set => SetProperty(ref _authorAssociationLabel, value); }
        #endregion

        public async Task SetMarkdownCommentToWebViewAsync(WebView webView)
        {
            CreatedAtHumanized = IssueComment?.CreatedAt.Humanize();

            string authorAssociation = IssueComment?.AuthorAssociation.Humanize();
            if (authorAssociation != "None") AuthorAssociationLabel.Name = authorAssociation;

            MarkdownApiHandler markdown = new();
            var html = await markdown.GetHtmlAsync(IssueComment?.BodyHTML, IssueComment?.Url, ThemeHelper.ActualTheme.ToString().ToLower());
            webView.NavigateToString(html);
        }
    }
}
