using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace AutoStartExlive
{
    class Program
    {
        static void Main(string[] args)
        {

            Process proc = null;

            try
            {
                proc = new Process();
                proc.StartInfo.FileName = @"G:\newexlive\ctbeizhu\start.bat";
                proc.StartInfo.Arguments = string.Format("10");//this is argument
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
                proc.WaitForExit();
                Console.WriteLine("00启动楚天备注服务，【已启动】，请稍等...");

                proc.StartInfo.FileName = @"G:\newexlive\gserver\jboss-5.1.0\bin\setup.bat";
                proc.StartInfo.Arguments = string.Format("10");//this is argument
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
                //proc.WaitForExit();
                Console.WriteLine("01启动后台管理，【已启动】，请稍等...");

                proc.StartInfo.FileName = @"G:\newexlive\gserver\tomcat-6.0.18\bin\setup.bat";
                proc.StartInfo.Arguments = string.Format("10");//this is argument
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
                //proc.WaitForExit();
                Console.WriteLine("02启动网上查车，【已启动】，请稍等...");

                proc.StartInfo.FileName = @"G:\newexlive\gserver\GServer.exe";
                proc.StartInfo.Arguments = string.Format("10");//this is argument
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
                //proc.WaitForExit();
                Console.WriteLine("03车辆定位服务器，【已启动】，请稍等...");

                Console.WriteLine("【全部服务已启动】，3s后退出启动脚本...");
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
            }


            //string exe_Path0 = @"cd /d G:\newexlive\ctbeizhu";                      //00启动楚天备注服务,start.bat
            //string exe_Path1 = @"cd /d G:\newexlive\gserver\jboss-5.1.0\bin";       //01启动后台管理,setup.bat
            //string exe_Path2 = @"cd /d G:\newexlive\gserver\tomcat-6.0.18\bin";     //02启动网上查车,setup.bat
            //string exe_Path3 = @"cd /d G:\newexlive\gserver";                       //03车辆定位服务器,GServer.exe

            //Process p = new Process();
            //p.StartInfo.FileName = "cmd.exe";
            //p.StartInfo.UseShellExecute = false;
            //p.StartInfo.RedirectStandardInput = true;
            //p.StartInfo.RedirectStandardOutput = true;
            //p.StartInfo.RedirectStandardError = true;
            //p.StartInfo.CreateNoWindow = false;

            //p.Start();

            //p.StandardInput.WriteLine(exe_Path0);
            //p.StandardInput.WriteLine("start.bat");
            //Console.WriteLine("00启动楚天备注服务，【已启动】，请稍等...");
            //Thread.Sleep(5000);

            //p.StandardInput.WriteLine(exe_Path1);
            //p.StandardInput.WriteLine("setup.bat");
            //Console.WriteLine("01启动后台管理，【已启动】，请稍等...");
            //Thread.Sleep(5000);

            //p.StandardInput.WriteLine(exe_Path2);
            //p.StandardInput.WriteLine("setup.bat");
            //Console.WriteLine("02启动网上查车，【已启动】，请稍等...");
            //Thread.Sleep(5000);

            //p.StandardInput.WriteLine(exe_Path3);
            //p.StandardInput.WriteLine("setup.bat");
            //Console.WriteLine("03车辆定位服务器，【已启动】，请稍等...");
            //Thread.Sleep(5000);

            //Console.WriteLine("【全部服务已启动】，结束...");
            //Thread.Sleep(2000);
            
        }
    }
}
