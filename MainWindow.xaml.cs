using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
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

namespace WpfApp1
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

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ComboBox1.SelectedIndex == 0)
                {
                    Output.Text = Io.Decalage(Input.Text);
                }
                else if (ComboBox1.SelectedIndex == 1)
                {
                    Output.Text = Io.Binary(Input.Text);
                }
                else if (ComboBox1.SelectedIndex == 2)
                {
                    Output.Text = Io.VigenèreCipher(Input.Text,Key.Text);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("A handled exception just occurred: " + exception.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
            
        }
        
    }
}
