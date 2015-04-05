using Flash_It.DependencyServices;
using Flash_It.Helpers;
using Flash_It.Preferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Flash_It.CustomControls
{
    public partial class ProfilePreferencesControl : ContentView
    {
        public ProfilePreferencesControl()
        {
            InitializeComponent();

            this.BackgroundColor = UIPreferences.WhiteBackgroundColor;

            NormalModeSwitch.IsToggled = DependencyService.Get<IRingerPreferences>().GetNormalModeEnabled();
            VibrateModeSwitch.IsToggled = DependencyService.Get<IRingerPreferences>().GetVibrateModeEnabled();
            SilentModeSwitch.IsToggled = DependencyService.Get<IRingerPreferences>().GetSilentModeEnabled();
        }

        private void NormalModeSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            DependencyService.Get<IRingerPreferences>().SetNormalModeEnabled(NormalModeSwitch.IsToggled);
        }

        private void VibrateModeSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            DependencyService.Get<IRingerPreferences>().SetVibrateModeEnabled(VibrateModeSwitch.IsToggled);
        }

        private void SilentModeSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            DependencyService.Get<IRingerPreferences>().SetSilentModeEnabled(SilentModeSwitch.IsToggled);
        }
    }
}
