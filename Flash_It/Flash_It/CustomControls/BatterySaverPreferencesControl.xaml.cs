using Flash_It.DependencyServices;
using Flash_It.Preferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Flash_It.CustomControls
{
    public partial class BatterySaverPreferencesControl : ContentView
    {
        public BatterySaverPreferencesControl()
        {
            InitializeComponent();

            this.BackgroundColor = UIPreferences.PreferencesControlBackgroundColor;

            MinBatterySlider.Value = DependencyService.Get<IBatterySaverPreferences>().GetBatteryMinLevel();

            EnabledSwitch.IsToggled = DependencyService.Get<IBatterySaverPreferences>().GetEnabled();
        }

        private void EnabledSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            DependencyService.Get<IBatterySaverPreferences>().SetEnabled(EnabledSwitch.IsToggled);
        }

        private void MinBatterySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)Math.Ceiling(MinBatterySlider.Value);

            DependencyService.Get<IBatterySaverPreferences>().SetBatteryMinLevel(value);

            SliderValueLabel.Text = value + "%";
        }
    }
}
