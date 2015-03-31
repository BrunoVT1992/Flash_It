using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash_It.DependencyServices
{
    public interface IBatterySaverPreferences
    {
        Boolean GetEnabled();
        void SetEnabled(Boolean enabled);

        int GetBatteryMinLevel();
        void SetBatteryMinLevel(int batteryMinLevel);
    }
}
