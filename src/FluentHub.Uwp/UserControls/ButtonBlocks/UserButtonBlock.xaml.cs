﻿using FluentHub.Uwp.Services;
using FluentHub.Uwp.ViewModels.UserControls.ButtonBlocks;
using Microsoft.Extensions.DependencyInjection;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace FluentHub.Uwp.UserControls.ButtonBlocks
{
    public sealed partial class UserButtonBlock : UserControl
    {
        #region propdp
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register(
                nameof(User),
                typeof(UserButtonBlockViewModel),
                typeof(UserButtonBlock),
                new PropertyMetadata(null));

        public UserButtonBlockViewModel ViewModel
        {
            get => (UserButtonBlockViewModel)GetValue(ViewModelProperty);
            set
            {
                SetValue(ViewModelProperty, value);
                this.DataContext = ViewModel;
            }
        }
        #endregion

        public UserButtonBlock() => InitializeComponent();

        private void UserButtonBlockButton_Click(object sender, RoutedEventArgs e)
        {
            var service = App.Current.Services.GetRequiredService<INavigationService>();

            if (ViewModel.User.Id.ToString().StartsWith("O_"))
            {
                service.Navigate<Views.Organizations.ProfilePage>(ViewModel.User.Login);
            }
            else
            {
                service.Navigate<Views.Users.OverviewPage>(
                    new Models.FrameNavigationArgs()
                    {
                        Login = ViewModel.User.Login,
                    });
            }
        }
    }
}
