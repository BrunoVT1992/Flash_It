using Flash_It.DependencyServices;
using Flash_It.Helpers;
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

            this.BackgroundImage = "Background";

            AppVersionlabel.Text = DependencyService.Get<IAppData>().GetAppVersion();

            this.Title = "Flash It";
        }
    }
}
