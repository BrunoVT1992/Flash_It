using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash_It.DependencyServices
{
    public interface IRingerPreferences
    {
        Boolean GetNormalModeEnabled();
        void SetNormalModeEnabled(Boolean enabled);

        Boolean GetVibrateModeEnabled();
        void SetVibrateModeEnabled(Boolean enabled);

        Boolean GetSilentModeEnabled();
        void SetSilentModeEnabled(Boolean enabled);
    }
}
