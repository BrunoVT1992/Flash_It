using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash_It.DependencyServices
{
    public interface ISmsPreferences
    {
        Boolean GetEnabled();
        void SetEnabled(Boolean enabled);

        int GetOnTime();
        void SetOnTime(int onTime);

        int GetOffTime();
        void SetOffTime(int offTime);

        int GetNumberOfTimes();
        void SetNumberOfTimes(int numberOfTimes);
    }
}
