using System;

namespace DAQ.Environment
{
	/// <summary>
	/// 
	/// </summary>
	public class D006MMTFZ400FileSystem : DAQ.Environment.FileSystem
	{
        public D006MMTFZ400FileSystem()
		{
			Paths.Add("settingsPath","C:\\Users\\MMTF\\Documents\\EDMSuiteData\\settings");
            Paths.Add("scanMasterDataPath", "C:\\Users\\MMTF\\Documents\\EDMSuiteData\\ScanMaster\\data");
			//Paths.Add("mathPath", "c:/program files/wolfram research/mathematica/5.2/mathkernel.exe");
            Paths.Add("fakeData", "C:\\Users\\MMTF\\Documents\\EDMSuiteData\\ScanMaster\\fakedata");

			DataSearchPaths.Add(Paths["scanMasterDataPath"]);
				
			SortDataByDate = true;
		}
	}
}
