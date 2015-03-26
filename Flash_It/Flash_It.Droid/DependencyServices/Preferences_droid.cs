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
using Xamarin.Forms;
using Flash_It.Droid.DependencyServices;
using Application = Android.App.Application;
using Flash_It.DependencyServices;

[assembly: Dependency(typeof(Preferences_Droid))]

namespace Flash_It.Droid.DependencyServices
{
    public class Preferences_Droid : IPreferences
    {
        public string GetString(string key)
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
            return prefs.GetString(key, null);
        }

        public void SetString(string key, string value)
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
            ISharedPreferencesEditor editor = prefs.Edit();
            editor.PutString(key, value.ToString());
            editor.Apply();
        }

        public int GetInt(string key)
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
            return prefs.GetInt(key, -1000);
        }

        public void SetInt(string key, int value)
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
            ISharedPreferencesEditor editor = prefs.Edit();
            editor.PutInt(key, value);
            editor.Apply();
        }

        public double GetDouble(string key)
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
            return Convert.ToDouble(prefs.GetString(key, null));
        }

        public void SetDouble(string key, double value)
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
            ISharedPreferencesEditor editor = prefs.Edit();
            editor.PutString(key, value.ToString());
            editor.Apply();
        }

        public bool GetBoolean(string key)
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
            return Convert.ToBoolean(prefs.GetString(key, null));
        }

        public void SetBoolean(string key, bool value)
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
            ISharedPreferencesEditor editor = prefs.Edit();
            editor.PutString(key, value.ToString());
            editor.Apply();
        }

        public DateTime GetDateTime(string key)
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
            return Convert.ToDateTime(prefs.GetString(key, null));
        }

        public void SetDateTime(string key, DateTime value)
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
            ISharedPreferencesEditor editor = prefs.Edit();
            editor.PutString(key, value.ToString());
            editor.Apply();
        }
    }
}