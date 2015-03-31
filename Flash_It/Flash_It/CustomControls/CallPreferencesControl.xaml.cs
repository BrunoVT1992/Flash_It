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
    public partial class CallPreferencesControl : ContentView
    {
        public CallPreferencesControl()
        {
            InitializeComponent();

            this.BackgroundColor = UIPreferences.PreferencesControlBackgroundColor;

            OnTimeSlider.Value = DependencyService.Get<ICallPreferences>().GetOnTime();
            OffTimeSlider.Value = DependencyService.Get<ICallPreferences>().GetOffTime();

            EnabledSwitch.IsToggled = DependencyService.Get<ICallPreferences>().GetEnabled();
        }

        private void OffTimeSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)Math.Round(OffTimeSlider.Value / 50) * 50;

            DependencyService.Get<ICallPreferences>().SetOffTime(value);

            OffTimeSliderValueLabel.Text = value + ResourceHelper.GetStringFromName("Miliseconds");
        }

        private void OnTimeSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)Math.Round(OnTimeSlider.Value / 50) * 50;

            DependencyService.Get<ICallPreferences>().SetOnTime(value);

            OnTimeSliderValueLabel.Text = value + ResourceHelper.GetStringFromName("Miliseconds");
        }

        private void EnabledSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            DependencyService.Get<ICallPreferences>().SetEnabled(EnabledSwitch.IsToggled);
        }
    }
}
