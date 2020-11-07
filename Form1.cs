using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace FoodAppWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
        }

        //This is my one of firsts win forms programs so I choose wrong .NET version.
        //In .NET Core there is a problem with openi
        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            mySecondCustomControl1.BringToFront();
        }

        private void ExitButton_Click(object sender, EventArgs e) => Application.Exit();

        private void button8_Click(object sender, EventArgs e) => OpenUrl("https://www.facebook.com/piotr.apriasz");

        private void button9_Click(object sender, EventArgs e) => OpenUrl("https://www.instagram.com/ejpriaszz/");

        private void button10_Click(object sender, EventArgs e) => OpenUrl("https://github.com/PiotrApriasz");

        //Popup window with information about program. Cointains App's name, creator's informations and version
        private void button14_Click(object sender, EventArgs e)
        {
            var popup = new infoPopup();
            popup.ShowDialog();
        }
    }
}
