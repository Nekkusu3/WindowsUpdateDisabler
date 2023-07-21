using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsUpdateDisabler
{
    public partial class WindowsUpdateDisabler : Form
    {
        public WindowsUpdateDisabler()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            RegistryKey key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer");
            key.SetValue("NoWindowsUpdate", 1, RegistryValueKind.DWord);
            key.Close();

            RegistryKey key2 = Registry.LocalMachine.CreateSubKey(@"Software\Policies\Microsoft\Windows\WindowsUpdate\AU");
            key2.SetValue("NoAutoUpdate", 1, RegistryValueKind.DWord);
            key2.Close();

            button1.Text = "Success!";

        }


        private void OpenHarambe(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.harambe.ch");
        }
    }
}
