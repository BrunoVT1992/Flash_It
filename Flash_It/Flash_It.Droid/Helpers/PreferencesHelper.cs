using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Preferences;

namespace Flash_It.Droid.Helpers
{
    public static class PreferencesHelper
    {
        public static string GetString(string key)
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
            return prefs.GetString(key, null);
        }

        public static void SetString(string key, string value)
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
            ISharedPreferencesEditor editor = prefs.Edit();
            editor.PutString(key, value.ToString());
            editor.Apply();
        }

        public static int GetInt(string key)
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
            return prefs.GetInt(key, -1000);
        }

        public static void SetInt(string key, int value)
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
            ISharedPreferencesEditor editor = prefs.Edit();
            editor.PutInt(key, value);
            editor.Apply();
        }

        public static double GetDouble(string key)
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
            return Convert.ToDouble(prefs.GetString(key, null));
        }

        public static void SetDouble(string key, double value)
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
            ISharedPreferencesEditor editor = prefs.Edit();
            editor.PutString(key, value.ToString());
            editor.Apply();
        }

        public static bool GetBoolean(string key)
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
            return Convert.ToBoolean(prefs.GetString(key, null));
        }

        public static void SetBoolean(string key, bool value)
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
            ISharedPreferencesEditor editor = prefs.Edit();
            editor.PutString(key, value.ToString());
            editor.Apply();
        }

        public static DateTime GetDateTime(string key)
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
            return Convert.ToDateTime(prefs.GetString(key, null));
        }

        public static void SetDateTime(string key, DateTime value)
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
            ISharedPreferencesEditor editor = prefs.Edit();
            editor.PutString(key, value.ToString());
            editor.Apply();
        }
    }
}