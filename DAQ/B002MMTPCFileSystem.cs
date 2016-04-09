using System;

namespace DAQ.Environment
{
    public class B002MMTPCFileSystem : DAQ.Environment.FileSystem
    {
        public B002MMTPCFileSystem()
        {
            Paths.Add("settingsPath", "C:\\Users\\Equipe\\Documents\\EDMSuiteData\\Settings");
            Paths.Add("scanMasterDataPath", "C:\\Users\\Equipe\\Documents\\EDMSuiteData\\Data");
            Paths.Add("fakeData", "C:\\Users\\Equipe\\Documents\\EDMSuiteData\\Fakedata");

            DataSearchPaths.Add(Paths["scanMasterDataPath"]);

            SortDataByDate = true;
        }
    }
}
