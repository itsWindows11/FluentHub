﻿using FluentHub.Uwp.ViewModels.UserControls.Blocks;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace FluentHub.Uwp.UserControls.Blocks
{
    public sealed partial class DiffBlock : UserControl
    {
        #region propdp
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register(
                nameof(ViewModel),
                typeof(DiffBlockViewModel),
                typeof(DiffBlock),
                new PropertyMetadata(null));

        public DiffBlockViewModel ViewModel
        {
            get => (DiffBlockViewModel)GetValue(ViewModelProperty);
            set
            {
                SetValue(ViewModelProperty, value);
                DataContext = ViewModel;
                ViewModel.Creanup();
            }
        }
        #endregion

        public DiffBlock() => InitializeComponent();

        private void OnExpandCollapseTogglingButton(object sender, RoutedEventArgs e)
        {
            if (ViewModel.BlockIsExpanded) ViewModel.BlockIsExpanded = false;
            else ViewModel.BlockIsExpanded = true;
        }
    }
}
