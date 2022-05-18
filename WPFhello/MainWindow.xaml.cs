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

namespace WPFHello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListBoxItem james = new ListBoxItem();
            james.Content = "James";
            peopleListBox.Items.Add(james);
            ListBoxItem david = new ListBoxItem();
            david.Content = "David";
            peopleListBox.Items.Add(david);

            peopleListBox.ScrollIntoView(david);
            peopleListBox.SelectedItem = james;
        }

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            if(txtName.Text.Length <= 1)
            {
                MessageBox.Show(" ");
            }
            else
            {
                MessageBox.Show("Здрасти " + txtName.Text + "!\nЧестита първа програма");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
             MessageBox.Show("This is Windows Presentation Foundation!");
             textBlock1.Text = DateTime.Now.ToString();
            
        }
    }
}
