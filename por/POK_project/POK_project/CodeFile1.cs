using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace POK_project
{
    class Common
    {
        public static int StringToHex(String str)
        {
            int nReturn = -1;
            try
            {
                nReturn = Convert.ToInt32(str, 16);
                return nReturn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return nReturn;
        }

        public static string HexToString(Int32 n)
        {
            string str = String.Empty;
            try
            {
                str = String.Format("{0:X}", n);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return str;
        }
    }
}