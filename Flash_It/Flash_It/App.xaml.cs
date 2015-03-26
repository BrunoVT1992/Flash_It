using Flash_It.Helpers;
using Flash_It.Pages;
using Flash_It.Preferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Flash_It
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            InitialSetupHelper.CheckInitialSetup();

            this.MainPage = new NavigationPage(new SettingsPage())
            {
                BarTextColor = Color.White,
                BarBackgroundColor = UIPreferences.BasicColor
            };
        }
    }
}
