using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cs06_5_StatusBarMenuBar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click_Open(object sender, RoutedEventArgs e)
        {
            //WindowOpen wOpen = new WindowOpen();
            //wOpen.Show();

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.DefaultExt = ".txt"; // Required file extension 
            fileDialog.Filter = "Text documents (.txt)|*.txt"; // Optional file extensions

            fileDialog.ShowDialog();

            if (fileDialog.ShowDialog() == DialogResult.HasValue)
            {

                try
                {
                    using (StreamReader file = new StreamReader(fileDialog.FileName)
                    {
                        while (!file.EndOfStream)
                            {

                                tbText.Text += file.ReadLine();
                            }
                    }   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "File not found");
                    return;
                }
            }
            //tbText.Text = sr.ReadToEnd();
            file.Close(); 
            }
        }

        private void MenuItem_Click_SaveAs(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click_About(object sender, RoutedEventArgs e)
        {
            tbText.Text = "About about about about about about about about about about about about about about about about about about about about about about about about.";
        }
    }
}
