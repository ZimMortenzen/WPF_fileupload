using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace cs06_5_StatusBarMenuBar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string fileContent = string.Empty;
        private string filePath = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click_Open(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            
            if (fileDialog.ShowDialog() == true)
            {
                filePath = fileDialog.FileName;
                tbText.Text = File.ReadAllText(filePath);
            }

            tbStatusBar.Text = "Open";
        }
 

        private void MenuItem_Click_SaveAs(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == true)
            {
                string savePath = saveFileDialog.FileName;

                using (StreamWriter sw = File.CreateText(savePath))
                {
                    sw.WriteLine(tbText.Text);
                }
            }

            tbStatusBar.Text = "Saved As";
        }

        private void MenuItem_Click_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click_About(object sender, RoutedEventArgs e)
        {
            tbText.Text = "About about about about about about about about about about about about about about about about about about about about about about about about.";
            tbStatusBar.Text = "About";
        }

    }
}
