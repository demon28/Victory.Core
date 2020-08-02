using System;
using System.Collections.Generic;
using System.Management;
using System.Text;

namespace Victory.Core.Helpers
{
  public static  class MachineHelper
    {

        /// <summary>
        /// 获取CPU编号
        /// </summary>
        /// <returns></returns>
        public static string GetCpuId() {


            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            string strID = null;
            foreach (ManagementObject mo in moc)
            {
                strID = mo.Properties["ProcessorId"].Value.ToString();
                break;
            }

            return strID;
        }

        /// <summary>
        /// 获取主板id
        /// </summary>
        /// <returns></returns>
        public static string GetBoardId() {

            ManagementClass mc = new ManagementClass("Win32_BaseBoard");
            ManagementObjectCollection moc = mc.GetInstances();
            string strID = null;
            foreach (ManagementObject mo in moc)
            {
                strID = mo.Properties["SerialNumber"].Value.ToString();
                break;
            }
            return strID;
        }


        /// <summary>
        /// 获取网卡地址
        /// </summary>
        /// <returns></returns>
        public static string GetNetworkAddress()
        {

            string MoAddress = string.Empty;
            ManagementClass networkAdapter = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection adapterC = networkAdapter.GetInstances();
            foreach (ManagementObject m in adapterC)
            {
                if ((bool)m["IPEnabled"] == true)
                {
                    MoAddress = m["MacAddress"].ToString().Trim();
                    m.Dispose();
                }
            }
            return MoAddress;

        }

    }
}
