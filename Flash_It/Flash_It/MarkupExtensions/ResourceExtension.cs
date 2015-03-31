using Flash_It.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Flash_It.MarkupExtensions
{
    [ContentProperty("Text")]
    public class ResourceExtension : IMarkupExtension
    {
        public string Name { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return ResourceHelper.GetStringFromName(Name);
        }
    }
}
