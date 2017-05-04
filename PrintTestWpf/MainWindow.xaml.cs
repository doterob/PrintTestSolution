using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrintTestWpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PrintHelper print;

        public MainWindow()
        {
            InitializeComponent();
            Init();
            print = new RawPrintHelper();
        }

        private void Init()
        {
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                printers.Items.Add(printer);
            }
        }

        private void printButton_Click(object sender, RoutedEventArgs e)
        {

            print.Print(printers.SelectedItem.ToString(), resource.Text);
        }
        
    }
}
