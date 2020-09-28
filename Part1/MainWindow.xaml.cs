/// Homework 4
/// File Name: BMI calculator
/// @author: Dakota Durst
/// Date: september 28, 2020
///
/// Problem Statement: 
/// Ask the user to enter their height and weight into a box, use values to calculate BMI and output if user's BMI is in a good range
///
///
/// Overall Plan:
/// 1) create visual display where user inputs values
/// 2) assign variables for height and weight
/// 3) Calulate BMI based on Height and weight
/// 4) Using If statments, created 3 potential cases based on BMI of user
/// 5) display popup with BMI value with a color based on its range.

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

namespace Part1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double weight;
            double height;

            weight = double.Parse(Weightbox.Text);
            height = double.Parse(Heightbox.Text);

            double BMI = weight * 720 / (height * height);

            if (BMI < 15)
            {
                Range.Background = Brushes.Blue;
                MessageBox.Show("Your BMI is equal to: " + BMI.ToString("0.00") +  " You are below the BMI healthy range");

            }
            else if (BMI >= 15 &&  BMI <= 26)
            {
                Range.Background = Brushes.Green;
                MessageBox.Show("Your BMI is equal to: " + BMI.ToString("0.00") + " You are inside the BMI healthy range");
            }
            else
            {
                Range.Background = Brushes.Yellow;
                MessageBox.Show("Your BMI is equal to: " + BMI.ToString("0.00") + " You are above the BMI healthy range");
            }
                
        }
    }
}
