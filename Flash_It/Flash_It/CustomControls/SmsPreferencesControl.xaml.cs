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
    public partial class SmsPreferencesControl : ContentView
    {
        public SmsPreferencesControl()
        {
            InitializeComponent();

            this.BackgroundColor = UIPreferences.WhiteBackgroundColor;

            OnTimeSlider.Value = DependencyService.Get<ISmsPreferences>().GetOnTime();
            OffTimeSlider.Value = DependencyService.Get<ISmsPreferences>().GetOffTime();
            NumberOfTimesSlider.Value = DependencyService.Get<ISmsPreferences>().GetNumberOfTimes();

            EnabledSwitch.IsToggled = DependencyService.Get<ISmsPreferences>().GetEnabled();
        }

        private void NumberOfTimesSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)Math.Ceiling(NumberOfTimesSlider.Value);

            DependencyService.Get<ISmsPreferences>().SetNumberOfTimes(value);

            NumberOfTimesSliderValueLabel.Text = value.ToString();
        }

        private void OffTimeSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)Math.Round(OffTimeSlider.Value / 50) * 50;

            DependencyService.Get<ISmsPreferences>().SetOffTime(value);

            OffTimeSliderValueLabel.Text = value + ResourceHelper.GetStringFromName("Miliseconds");
        }

        private void OnTimeSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)Math.Round(OnTimeSlider.Value / 50) * 50;

            DependencyService.Get<ISmsPreferences>().SetOnTime(value);

            OnTimeSliderValueLabel.Text = value + ResourceHelper.GetStringFromName("Miliseconds");
        }

        private void EnabledSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            DependencyService.Get<ISmsPreferences>().SetEnabled(EnabledSwitch.IsToggled);
        }
    }
}
