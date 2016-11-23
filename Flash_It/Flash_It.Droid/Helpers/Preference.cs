using System;
using Android.App;
using Android.Content;
using Android.Preferences;

namespace Flash_It.Droid.Helpers
{
    public class Preference
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