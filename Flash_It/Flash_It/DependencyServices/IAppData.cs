using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash_It.DependencyServices
{
    public interface IAppData
    {
        string GetAppVersion();

        string GetSystemLanguage();

        string GetSystemCulture();
    }
}
