using System;
using System.Collections;
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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        string num1 =string.Empty;
        string num2 = string.Empty;
        string oper = string.Empty;
        string eq = string.Empty;
       public  ArrayList al = new ArrayList();

        public UserControl1()
        {
            InitializeComponent();
            ArraytoDatatable(al);
        }


        public UserControl1(string num1, string num2, string oper, string eq)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.oper = oper;
            this.eq = eq;
        }


        public void addToArray(UserControl1 p)

        {
            al.Add(p);

        }

        public void clearData()
        {
            al.Clear();
        }

        public void ArraytoDatatable(ArrayList al)

        {

            Console.WriteLine(al.ToString());
            foreach (UserControl1 p in al)
            {
                table.Text += p.num1 + "" + p.oper + "" + p.num2 + " =\n";

                Console.WriteLine(p);

            }

       table.ToString();


        }

          }
}
