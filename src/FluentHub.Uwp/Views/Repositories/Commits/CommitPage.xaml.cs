﻿using FluentHub.Uwp.Models;
using FluentHub.Uwp.Services;
using FluentHub.Uwp.Services.Navigation;
using FluentHub.Uwp.ViewModels.Repositories.Commits;
using Microsoft.Extensions.DependencyInjection;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;
using muxc = Microsoft.UI.Xaml.Controls;

namespace FluentHub.Uwp.Views.Repositories.Commits
{
    public sealed partial class CommitPage : Page
    {
        public CommitPage()
        {
            InitializeComponent();

            var provider = App.Current.Services;
            ViewModel = provider.GetRequiredService<CommitViewModel>();
            navigationService = App.Current.Services.GetRequiredService<INavigationService>();
        }

        public CommitViewModel ViewModel { get; }
        private readonly INavigationService navigationService;

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            var param = e.Parameter as FrameNavigationArgs;
            ViewModel.CommitItem = param.Parameters.ElementAt(0) as Commit;

            await ViewModel.LoadRepositoryAsync(param.Login, param.Name);

            SetCurrentTabItem();

            var command = ViewModel.LoadCommitPageCommand;
            if (command.CanExecute(null))
                command.Execute(null);
        }

        private void SetCurrentTabItem()
        {
            var currentItem = navigationService.TabView.SelectedItem.NavigationHistory.CurrentItem;
            currentItem.Header = "Commits";
            currentItem.Description = "Commits";
            currentItem.Icon = new muxc.ImageIconSource
            {
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Icons/Commits.png"))
            };
        }
    }
}
