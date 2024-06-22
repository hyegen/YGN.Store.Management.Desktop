using System;
using System.Collections.Generic;
using System.Configuration.Install;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YGN.Store.Management.Sys.Managers
{
    public class ServiceManager
    {
        private string ServiceName { get; set; }

        public ServiceManager(string serviceName)
        {
            ServiceName = serviceName;
        }

        public void UninstallService()
        {
            try
            {
                using (ServiceController serviceController = new ServiceController(ServiceName))
                {
                    if (serviceController.Status == ServiceControllerStatus.Running)
                    {
                        serviceController.Stop();
                        serviceController.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(10));
                    }
                }

                ManagedInstallerClass.InstallHelper(new string[] { "/u", Assembly.GetExecutingAssembly().Location });

                Process scProcess = new Process();
                scProcess.StartInfo.FileName = "sc";
                scProcess.StartInfo.Arguments = $"delete {ServiceName}";
                scProcess.StartInfo.RedirectStandardOutput = true;
                scProcess.StartInfo.RedirectStandardError = true;
                scProcess.StartInfo.UseShellExecute = false;
                scProcess.StartInfo.CreateNoWindow = true;
                scProcess.Start();

                string output = scProcess.StandardOutput.ReadToEnd();
                string error = scProcess.StandardError.ReadToEnd();
                scProcess.WaitForExit();

                if (scProcess.ExitCode == 0)
                {
                    MessageBox.Show("Servis başarıyla kaldırıldı.");
                }
                else
                {
                    MessageBox.Show($"Kaldırma sırasında hata oluştu: {error}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaldırma sırasında hata oluştu: " + ex.Message);
            }
        }
    }
}
