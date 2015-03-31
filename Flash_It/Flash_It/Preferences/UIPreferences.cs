using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Flash_It.Preferences
{
    public static class UIPreferences
    {
        public static Color BasicColor
        {
            get {
                //return Color.FromHex("#557BD4");
                return Color.FromHex("#29738C");
            }
        }

        public static Color PreferencesControlBackgroundColor
        {
            get
            {
                return Color.White.MultiplyAlpha(0.7);
            }
        }
    }
}
