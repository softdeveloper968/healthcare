﻿using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace GaHealthcareNurses.Helpers
{
    /// <summary>
    /// This is the Settings static class that can be used in your Core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters. 
    /// Checking
    /// </summary> 
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants
        private const string AccessToken = "AccessToken";
        private static readonly string AccessTokenDefault = string.Empty;  
        public static string GeneralAccessToken
        {
            get
            {
                return AppSettings.GetValueOrDefault(AccessToken, AccessTokenDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(AccessToken, value);
            }
        } 
        #region JSONS
         
        #endregion
         
        #endregion

    }
}
