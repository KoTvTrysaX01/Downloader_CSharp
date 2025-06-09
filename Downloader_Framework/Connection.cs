using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Downloader_Framework
{
    public class Connection
    {


        public bool PingHost()
        {
            try
            {
                using (var client = new TcpClient())
                {
                    var result = client.BeginConnect("79.112.50.56", 22, null, null);
                    var success = result.AsyncWaitHandle.WaitOne(5000);
                    client.EndConnect(result);


                    MainFrame.lbl_ImageStatus.Invoke(new MethodInvoker(delegate
                    {
                        MainFrame.lbl_ImageStatus.Image = new Bitmap(Properties.Resources.happy, new Size(50, 50));
                        MainFrame.AppendTextToConsole("Successful connection.");
                    }));
                    ;

                    return true;
                }
            }
            catch (Exception ex)
            {
                MainFrame.lbl_ImageStatus.Invoke(new MethodInvoker(delegate
                {
                    MainFrame.lbl_ImageStatus.Image = new Bitmap(Properties.Resources.sad, new Size(50, 50));
                    MainFrame.AppendTextToConsole("Server is unreachable.");
                }));
                return false;
            }
        }
    }
}
