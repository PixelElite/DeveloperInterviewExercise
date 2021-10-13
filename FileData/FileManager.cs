using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
    public class FileManager
    {
        readonly ConfigManager _configurationManager = new ConfigManager();
        public string GetDetails(string command, string filePath)
        {
            try
            {
                string fileInfo = "";
                FileDetails fileDetails = new FileDetails();

                //Check if the command is valid for file version 
                if (_configurationManager.GetSupportedCommand_VersionList.Where(w=>w.Equals(command)).Any())
                {
                    fileInfo = $"File Version: {fileDetails.Version(filePath)}";
                }
                //Check if the command is valid for file size 
                else if (_configurationManager.GetSupportedCommand_SizeList.Where(w => w.Equals(command)).Any())
                {
                    fileInfo = $"File Size: {fileDetails.Size(filePath)}";
                }
                else
                {
                    throw new Exception("Invalid Command.");
                }
                return fileInfo;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
