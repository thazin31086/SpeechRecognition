using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ex1
{
    /// <summary>
    /// Interaction logic for ProcessListPage.xaml
    /// </summary>
    public partial class ProcessListPage : Window
    {
        public ProcessListPage()
        {
            InitializeComponent();

        }

        public void Getlist_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] processes = Process.GetProcesses();
                foreach (Process p in processes)
                {
                    if (!String.IsNullOrEmpty(p.MainWindowTitle))
                    {
                        txtInput.Text += p.MainWindowTitle + Environment.NewLine;
                    }
                }
            }
            catch (Exception err)
            {
                txtInput.Text = String.Format("Error : {0}", err);
            }
        }
        public void Back_Click(object sender, EventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
