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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

  
    {

        private bool flag=false;
        private double saved = 0;

        public string OP = string.Empty;
        private double memory = 0;




        public MainWindow()
        {
            InitializeComponent();


            MRBtn.IsEnabled = false;
            MCBtn.IsEnabled = false;




        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            Button btn = sender as Button;

            if(tRes.Text == "0" || flag == true)
            {
                tRes.Text = btn.Content.ToString();
                flag = false;
            }
            else
            {
                tRes.Text += btn.Content.ToString(); 
            }
               

        }

        //calc decimal num
        private void ButtonDot_Click(object sender, RoutedEventArgs e)
        {
            if (tRes.Text.Contains("."))
            {
                return;
            }

            else
                tRes.Text += ".";


        }

        private void PMBtn_Click(object sender, RoutedEventArgs e)
        {

            double d = double.Parse(tRes.Text);
            d = -d;
            tRes.Text = d.ToString();
        
        }

        private void OP_Click(object sender, RoutedEventArgs e)
        {

             flag = true;

            saved = double.Parse(tRes.Text);

            Button button = sender as Button;

            OP = button.Content.ToString();

            tExp.Text += tRes.Text + " " + OP;
            




        }

        private void ResBtn_Click(object sender, RoutedEventArgs e)
        {

            double r = double.Parse(tRes.Text);
                 switch (OP)
            {
                case "+":  tRes.Text = (saved + r).ToString(); break; 
                case "-":  tRes.Text = (saved - r).ToString(); break; 
                case "×":  tRes.Text = (saved * r).ToString(); break; 
                case "÷":



                    double result = (saved / r);
                    if (result == 0)
                    {
                        tRes.Text = "cannot divide by zero  error";
                                      }
                    else 
                    {
                        tRes.Text = result.ToString();
                
                    }
                    
                    break; 

            }

            tExp.Text = saved + " " + OP+ r + " =" ;

        }

        private void SqrBtn_Click(object sender, RoutedEventArgs e)
        {

            tExp.Text = "√(" + tRes.Text + ")";
            tRes.Text = Math.Sqrt(double.Parse(tRes.Text)).ToString();

        }

        private void ReBtn_Click(object sender, RoutedEventArgs e)
        {

            tExp.Text = "1 / (" + tRes.Text + ")";
            tRes.Text = (1 / double.Parse(tRes.Text)).ToString();
        }

        private void PerBtn_Click(object sender, RoutedEventArgs e)
        {
     
            tExp.Text = "%(" + tRes.Text + ")";
            tRes.Text = ((double.Parse(tRes.Text) / 100)*100).ToString() + "%";
        }

        private void PowBtn_Click(object sender, RoutedEventArgs e)
        {

            tExp.Text = "pow(" + tRes.Text + ")";
            tRes.Text = (double.Parse(tRes.Text)*(double.Parse(tRes.Text))).ToString();

        }

        private void CEBtn_Click(object sender, RoutedEventArgs e)
        {

            tRes.Text = "0";
        

        }

        private void CBtn_Click(object sender, RoutedEventArgs e)
        {
            tRes.Text = "0";
            tExp.Text = "";
            saved = 0;
            OP = "";
            flag = false;



        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {

            tRes.Text = tRes.Text.Remove(tRes.Text.Length - 1);

            if(tRes.Text.Length == 0)
            {
                tRes.Text = "0";
            }

        }

        private void MCBtn_Click(object sender, RoutedEventArgs e)
        {

            memory = 0;
            MCBtn.IsEnabled = false;
            MRBtn.IsEnabled = false;

        }

        private void MRBtn_Click(object sender, RoutedEventArgs e)
        {

            tRes.Text = memory.ToString();


        }

        private void MPBtn_Click(object sender, RoutedEventArgs e)
        {

            memory += double.Parse(tRes.Text);

        }

        private void MMBtn_Click(object sender, RoutedEventArgs e)
        {
            memory -= double.Parse(tRes.Text);
        }

        private void MSBtn_Click(object sender, RoutedEventArgs e)
        {

            memory = double.Parse(tRes.Text);
            MCBtn.IsEnabled = true;
            MRBtn.IsEnabled = true;



        }
    }
}
