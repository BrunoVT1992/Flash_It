using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Flash_It.CustomControls
{
    public partial class FlashSettingsControl : ContentView
    {
        public FlashSettingsControl()
        {
            InitializeComponent();

            this.BackgroundColor = Color.White.MultiplyAlpha(0.5);
        }

        public string Title
        {
            get
            {
                return TitleLabel.Text;
            }
            set
            {
                TitleLabel.Text = value;
            }
        }

        public string OnTimeText
        {
            get
            {
                return OnTimeLabel.Text;
            }
            set
            {
                OnTimeLabel.Text = value;
            }
        }

        public string OffTimeText
        {
            get
            {
                return OffTimeLabel.Text;
            }
            set
            {
                OffTimeLabel.Text = value;
            }
        }

        public string NumberOffTimesText
        {
            get
            {
                return NumberOffTimesLabel.Text;
            }
            set
            {
                NumberOffTimesLabel.Text = value;
            }
        }
    }
}
