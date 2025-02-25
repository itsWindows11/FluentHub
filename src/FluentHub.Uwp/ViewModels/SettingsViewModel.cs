﻿using FluentHub.Uwp.Helpers;
using FluentHub.Uwp.Models;
using FluentHub.Uwp.Utils;
using Windows.Globalization;

namespace FluentHub.Uwp.ViewModels
{
    public class SettingsViewModel : SettingsManager
    {
        public SettingsViewModel()
        {
            var supportedLang = ApplicationLanguages.ManifestLanguages;
            DefaultLanguages = new ObservableCollection<DefaultLanguageModel> { new DefaultLanguageModel(null) };

            foreach (var lang in supportedLang)
            {
                DefaultLanguages.Add(new DefaultLanguageModel(lang));
            }
        }

        #region Sign in
        public string AccessToken
        {
            get => Get(nameof(AccessToken), "");
            set => Set(nameof(AccessToken), value);
        }

        public bool SetupCompleted
        {
            get => Get(nameof(SetupCompleted), false);
            set => Set(nameof(SetupCompleted), value);
        }

        public bool SetupProgress
        {
            get => Get(nameof(SetupProgress), false);
            set => Set(nameof(SetupProgress), value);
        }

        public string SignedInUserName
        {
            get => Get(nameof(SignedInUserName), "");
            set => Set(nameof(SignedInUserName), value);
        }

        public string SignedInUserLogins // Divided with comma ','
        {
            get => Get(nameof(SignedInUserLogins), "");
            set => Set(nameof(SignedInUserLogins), value);
        }
        #endregion

        #region App settings
        public string AppTheme
        {
            get => Get(nameof(AppTheme), "Default");
            set => Set(nameof(AppTheme), value);
        }

        public string AppVersion
        {
            get => Get(nameof(AppVersion), "Unknown version");
            set => Set(nameof(AppVersion), value);
        }

        public bool UseDetailsView
        {
            get => Get(nameof(UseDetailsView), true);
            set => Set(nameof(UseDetailsView), value);
        }

        public ObservableCollection<DefaultLanguageModel> DefaultLanguages { get; private set; }

        public DefaultLanguageModel DefaultLanguage
        {
            get => DefaultLanguages.FirstOrDefault(dl => dl.ID == ApplicationLanguages.PrimaryLanguageOverride) ?? DefaultLanguages.FirstOrDefault();
            set => ApplicationLanguages.PrimaryLanguageOverride = value.ID;
        }

        public DefaultLanguageModel CurrentLanguage { get; set; } = new DefaultLanguageModel(ApplicationLanguages.PrimaryLanguageOverride);
        #endregion

        #region Others
        public string LastOpenedPageFrame
        {
            get => Get(nameof(LastOpenedPageFrame), nameof(Views.Home.UserHomePage));
            set => Set(nameof(LastOpenedPageFrame), value);
        }
        #endregion
    }
}
