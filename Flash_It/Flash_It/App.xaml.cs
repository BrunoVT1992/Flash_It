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

            this.MainPage = new NavigationPage(new Page1())
            {
                BarTextColor = Color.White,
                BarBackgroundColor = UIPreferences.BasicColor
            };
        }
    }
}
