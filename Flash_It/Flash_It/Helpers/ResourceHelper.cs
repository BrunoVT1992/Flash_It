using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Xamarin.Forms;
using Flash_It.DependencyServices;

namespace Flash_It.Helpers
{
    public static class ResourceHelper
    {
        public static string GetStringFromName(string name)
        {
            string response = "";

            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Name", "Name is empty");
            }
            else
            {
                var temp = new ResourceManager("Flash_It.Resources.LocaleResource", typeof(App).GetTypeInfo().Assembly);

                string result = temp.GetString(name, new CultureInfo(DependencyService.Get<IAppData>().GetSystemLanguage()));

                if (string.IsNullOrEmpty(result) || string.IsNullOrWhiteSpace(result))
                {
                    throw new ArgumentNullException("Result", "There is no value found for the given name: " + name);
                }
                else
                {
                    response = result;
                }
            }

            return response;
        }
    }
}
