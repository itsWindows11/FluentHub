﻿using FluentHub.Uwp.Helpers;
using FluentHub.Uwp.Models;
using FluentHub.Uwp.Utils;

namespace FluentHub.Uwp.ViewModels.UserControls.ButtonBlocks
{
    public class NotificationButtonBlockViewModel : ObservableObject
    {
        private Notification _item;
        public Notification Item { get => _item; set => SetProperty(ref _item, value); }
    }
}
