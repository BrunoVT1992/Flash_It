using Flash_It.DependencyServices;
using Flash_It.Helpers;
using Flash_It.Preferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Flash_It.Pages
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();

            AppVersionlabel.Text = DependencyService.Get<IAppData>().GetAppVersion();

            this.ToolbarItems.Add(new ToolbarItem("About", "About.png", AboutTapped));
        }

        private void AboutTapped()
        {
            Navigation.PushAsync(new AboutPage());
        }
    }
}
