using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.IO;

namespace TestWpf1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public System.Windows.Forms.OpenFileDialog openFileDialog1;  
         
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Combo.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Play Among Us" && Haxer.IsChecked == false)
            {
                try
                {
                    Process sus = new Process();

                    Process.Start(Textbox1.Text);
                }
                catch (Exception bruh)
                {
                    MessageBox.Show("Select a real file location or ratio", "PTJ IS CLUELESS");
                }
            }
            else if (Combo.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Play Among Us" && Haxer.IsChecked == true)
            {
                try
                {
                    MessageBox.Show("INITIATING MLG G4M3R H4X FOR AMONG US", "PTJ IS CLUELESS");
                    MessageBox.Show("OOPS WE GOT RATIOED AND FAILED LMFAO TRY AGAIN LATER", "PTJ IS CLUELESS");
                    MessageBox.Show("Among Us will be launched without haxes", "PTJ IS CLUELESS");

                    Process sus = new Process();

                    Process.Start(Textbox1.Text);
                }
                catch (Exception bruh)
                {
                    MessageBox.Show("Select a real file location or ratio", "PTJ IS CLUELESS");
                }
            }
            else if (Combo.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Select me if you're bruh")
            {
                MessageBox.Show("BRUH SUS", "PTJ IS CLUELESS");
            }
            else 
            {
                Form1 js = new Form1();
                js.Show();
            }
        }
        private void Button_Hover(object sender, RoutedEventArgs e)
        {
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine(Combo.SelectedItem.ToString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            openFileDialog1.ShowDialog();
            Textbox1.Text = openFileDialog1.FileName;
        }

        private void LeakIp() 
        {
            var rng = new Random();

            string ip = "0.0.0.0";

            ip = rng.Next(256) + "." + rng.Next(256) + "." + rng.Next(256) + "." + rng.Next(256);

            Textbox1_Copy.Text = ip;
        }

        private void Textbox1_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {
            LeakIp();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ŚRUH SUS", "PTJ IS CLUELESS");
        }

        private void DedGam_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Fal gus is ded gam wtf", "PTJ IS CLUELESS");
            DedGam.IsChecked = false;
        }

        private void among_Click(object sender, RoutedEventArgs e)
        {
            Window1 about = new Window1();
            about.Show();
        }

        private void among2_Click(object sender, RoutedEventArgs e)
        {
            Window2 newsfeed = new Window2();
            newsfeed.Show();
        }
    }
}
