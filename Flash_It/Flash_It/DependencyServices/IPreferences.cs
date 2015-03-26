using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash_It.DependencyServices
{
    public interface IPreferences
    {
        string GetString(string key);
        void SetString(string key, string value);

        int GetInt(string key);
        void SetInt(string key, int value);

        double GetDouble(string key);
        void SetDouble(string key, double value);

        Boolean GetBoolean(string key);
        void SetBoolean(string key, Boolean value);

        DateTime GetDateTime(string key);
        void SetDateTime(string key, DateTime value);
    }
}
