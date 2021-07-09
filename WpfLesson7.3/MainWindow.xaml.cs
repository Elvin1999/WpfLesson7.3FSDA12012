using System;
using System.Collections.Generic;
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
using WpfLesson7._3.Commands;

namespace WpfLesson7._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public RelayCommand MessageCommand { get; set; }
        public RelayCommand SendCommand { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;
            MessageCommand = new RelayCommand(Display);
            SendCommand = new RelayCommand(Send);

        }

        public void Display(object text = null)
        {
            MessageBox.Show("Hello Relay Command");
        }

        public void Send(object text = null)
        {
            MessageBox.Show("Message was sent");
        }

    }
}
