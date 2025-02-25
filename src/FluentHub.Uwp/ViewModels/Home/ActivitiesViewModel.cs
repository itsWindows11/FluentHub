﻿using FluentHub.Octokit.Queries.Users;
using FluentHub.Uwp.Models;
using FluentHub.Uwp.Utils;
using FluentHub.Uwp.ViewModels.UserControls.Blocks;

namespace FluentHub.Uwp.ViewModels.Home
{
    public class ActivitiesViewModel : ObservableObject
    {
        public ActivitiesViewModel(IMessenger messenger = null, ILogger logger = null)
        {
            _messenger = messenger;
            _logger = logger;
            _messenger = messenger;

            _userRepositories = new();
            UserRepositories = new(_userRepositories);

            _activities = new();
            Activities = new(_activities);

            RefreshActivitiesCommand = new AsyncRelayCommand(LoadActivitiesAsync);
        }

        #region Fields and Properties
        private readonly IMessenger _messenger;
        private readonly ILogger _logger;

        private readonly ObservableCollection<Repository> _userRepositories;
        public ReadOnlyObservableCollection<Repository> UserRepositories { get; }

        private readonly ObservableCollection<ActivityBlockViewModel> _activities;
        public ReadOnlyObservableCollection<ActivityBlockViewModel> Activities { get; }

        public IAsyncRelayCommand RefreshActivitiesCommand { get; }
        #endregion

        private async Task LoadActivitiesAsync(CancellationToken token)
        {
            try
            {
                _messenger?.Send(new LoadingMessaging(true));

                RepositoryQueries repositoryQueries = new();
                var repositoryResponse = await repositoryQueries.GetAllAsync(App.Settings.SignedInUserName);
                if (repositoryResponse == null) return;

                foreach (var item in repositoryResponse) _userRepositories.Add(item);

                ActivityQueries activityQueries = new();
                var activityResponse = await activityQueries.GetAllAsync(App.Settings.SignedInUserName);
                if (activityResponse == null) return;

                foreach (var item in activityResponse)
                {
                    ActivityBlockViewModel viewModel = new()
                    {
                        Payload = item,
                    };

                    _activities.Add(viewModel);
                }
            }
            catch (OperationCanceledException) { }
            catch (Exception ex)
            {
                _logger?.Error(nameof(LoadActivitiesAsync), ex);
                if (_messenger != null)
                {
                    UserNotificationMessage notification = new("Something went wrong", ex.Message, UserNotificationType.Error);
                    _messenger.Send(notification);
                }
                throw;
            }
            finally
            {
                _messenger?.Send(new LoadingMessaging(false));
            }
        }
    }
}
