using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    public class ConfigManager
    {
        readonly List<string> versionList = new List<string>();
        readonly List<string> sizeList = new List<string>();

        public List<string> GetSupportedCommand_VersionList
        {
            get
            {
                return versionList;
            }
        }
        public List<string> GetSupportedCommand_SizeList
        {
            get
            {
                return sizeList;
            }
        }
        public ConfigManager()
        {
            try
            {
                //Get various possible command strings for Version and Size from App.config
                versionList = Convert.ToString(ConfigurationManager.AppSettings["version"]).Split(',').ToList();
                sizeList = Convert.ToString(ConfigurationManager.AppSettings["size"]).Split(',').ToList();
            }
            catch
            {
                throw new Exception("Failed to read config.");
            }
        }
    }
}
