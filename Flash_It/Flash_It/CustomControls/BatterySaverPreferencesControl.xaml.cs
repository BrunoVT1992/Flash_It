using Flash_It.DependencyServices;
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

            TitleLabel.Text = "Battery saver";
            MinBatteryTitleLabel.Text = "Min battery level";

            this.BackgroundColor = Color.White.MultiplyAlpha(0.5);

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

            SliderValueLabel.Text = value.ToString();
        }
    }
}
