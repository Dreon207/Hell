using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
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

namespace P1
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

        public List<int> cnp = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, };

        private void Start(object sender, RoutedEventArgs e)
        {
            B1.IsEnabled = true;
            B2.IsEnabled = true;
            B3.IsEnabled = true;
            B4.IsEnabled = true;
            B5.IsEnabled = true;
            B6.IsEnabled = true;
            B7.IsEnabled = true;
            B8.IsEnabled = true;
            B9.IsEnabled = true;
            B1.Content = "";
            B2.Content = " ";
            B3.Content = "  ";
            B4.Content = "   ";
            B5.Content = "    ";
            B6.Content = "     ";
            B7.Content = "      ";
            B8.Content = "       ";
            B9.Content = "        ";
            
        }
        public void Robi()
        {
            int p = 0;
            if (B1.Content == "X")
            {
                p = 1;
                
                int z =cnp.IndexOf(0);
                cnp.Remove(z);

                Random rand = new Random();
                int randIndex = rand.Next(cnp.Count);
                int random = cnp[randIndex];
                if (random == 1)
                {
                    
                    int a = cnp.IndexOf(1);
                    cnp.Remove(a);
                    B2.Content = "0";
                    B2.IsEnabled = false;

                }
                if (random == 2)
                {
                    cnp.IndexOf(2);
                    int b = cnp.IndexOf(2);
                    cnp.Remove(b);
                    B3.Content = "0";
                    B3.IsEnabled = false;

                }
                if (random == 3)
                {
                    cnp.IndexOf(3);
                    int r = cnp.IndexOf(3);
                    cnp.Remove(r);
                    B4.Content = "0";
                    B4.IsEnabled = false;

                }
                if (random == 4)
                {
                    cnp.IndexOf(4);
                    int s = cnp.IndexOf(4);
                    cnp.Remove(s);
                    B5.Content = "0";
                    B5.IsEnabled = false;

                }
                if (random == 5)
                {
                    cnp.IndexOf(5);
                    int m = cnp.IndexOf(5);
                    cnp.Remove(m);
                    B6.Content = "0";
                    B6.IsEnabled = false;

                }
                if (random == 6)
                {
                    cnp.IndexOf(6);
                    int l = cnp.IndexOf(6);
                    cnp.Remove(l);
                    B7.Content = "0";
                    B7.IsEnabled = false;

                }
                if (random == 7)
                {
                    cnp.IndexOf(7);
                    int h = cnp.IndexOf(7);
                    cnp.Remove(h);
                    B8.Content = "0";
                    B8.IsEnabled = false;

                }
                if (random == 8)
                {
                    cnp.IndexOf(8);
                    int w = cnp.IndexOf(8);
                    cnp.Remove(w);
                    B9.Content = "0";
                    B9.IsEnabled = false;

                }
                


            }
            if (B2.Content == "X"&&p==0)
            {
                p = 1;
                cnp.IndexOf(1);
                int z = cnp.IndexOf(1);
                cnp.Remove(z);

                Random rand = new Random();
                int randIndex = rand.Next(cnp.Count);
                int random = cnp[randIndex];
                if (random == 0)
                {
                    cnp.IndexOf(0);
                    int n = cnp.IndexOf(0);
                    cnp.Remove(n);
                    B1.Content = "0";
                    B1.IsEnabled = false;

                }
                if (random == 2)
                {
                    cnp.IndexOf(2);
                    int m = cnp.IndexOf(2);
                    cnp.Remove(m);
                    B3.Content = "0";
                    B3.IsEnabled = false;

                }
                if (random == 3)
                {
                    cnp.IndexOf(3);
                    int q = cnp.IndexOf(3);
                    cnp.Remove(q); ;
                    B4.Content = "0";
                    B4.IsEnabled = false;

                }
                if (random == 4)
                {
                    cnp.IndexOf(4);
                    int x = cnp.IndexOf(4);
                    cnp.Remove(x);
                    B5.Content = "0";
                    B5.IsEnabled = false;

                }
                if (random == 5)
                {
                    cnp.IndexOf(5);
                    int d = cnp.IndexOf(5);
                    cnp.Remove(d);
                    B6.Content = "0";
                    B6.IsEnabled = false;

                }
                if (random == 6)
                {
                    cnp.IndexOf(6);
                    int o = cnp.IndexOf(6);
                    cnp.Remove(0);
                    B7.Content = "0";
                    B7.IsEnabled = false;

                }
                if (random == 7)
                {
                    cnp.IndexOf(7);
                    int f = cnp.IndexOf(7);
                    cnp.Remove(f);
                    B8.Content = "0";
                    B8.IsEnabled = false;

                }
                if (random == 8)
                {
                    cnp.IndexOf(8);
                    int r = cnp.IndexOf(8);
                    cnp.Remove(r);
                    B9.Content = "0";
                    B9.IsEnabled = false;

                }               


            }

            if (B3.Content == "X"&& p==0)
            {
                p = 1;
                cnp.Remove(2);
                
                Random rand = new Random();
                int randIndex = rand.Next(cnp.Count);
                int random = cnp[randIndex];
                if (random == 0)
                {
                    cnp.Remove(0);
                    B1.Content = "0";
                    B1.IsEnabled = false;

                }
                if (random == 1)
                {
                    cnp.Remove(1);
                    B2.Content = "0";
                    B2.IsEnabled = false;

                }
                if (random == 3)
                {
                    cnp.Remove(2);
                    B4.Content = "0";
                    B4.IsEnabled = false;

                }
                if (random == 4)
                {
                    cnp.Remove(4);
                    B5.Content = "0";
                    B5.IsEnabled = false;

                }
                if (random == 5)
                {
                    cnp.Remove(5);
                    B6.Content = "0";
                    B6.IsEnabled = false;

                }
                if (random == 6)
                {
                    cnp.Remove(6);
                    B7.Content = "0";
                    B7.IsEnabled = false;

                }
                if (random == 7)
                {
                    cnp.Remove(7);
                    B8.Content = "0";
                    B8.IsEnabled = false;

                }
                if (random == 8)
                {
                    cnp.Remove(8);
                    B9.Content = "0";
                    B9.IsEnabled = false;

                }

              
            }
            if (B4.Content == "X" && p == 0)
            {
                p = 1;
                cnp.Remove(3);

                Random rand = new Random();
                int randIndex = rand.Next(cnp.Count);
                int random = cnp[randIndex];
                if (random == 0)
                {
                    cnp.Remove(0);
                    B1.Content = "0";
                    B1.IsEnabled = false;

                }
                if (random == 1)
                {
                    cnp.Remove(1);
                    B2.Content = "0";
                    B2.IsEnabled = false;

                }
                if (random == 2)
                {
                    cnp.Remove(2);
                    B3.Content = "0";
                    B3.IsEnabled = false;

                }

                if (random == 4)
                {
                    cnp.Remove(4);
                    B5.Content = "0";
                    B5.IsEnabled = false;

                }
                if (random == 5)
                {
                    cnp.Remove(5);
                    B6.Content = "0";
                    B6.IsEnabled = false;

                }
                if (random == 6)
                {
                    cnp.Remove(6);
                    B7.Content = "0";
                    B7.IsEnabled = false;

                }
                if (random == 7)
                {
                    cnp.Remove(7);
                    B8.Content = "0";
                    B8.IsEnabled = false;

                }
                if (random == 8)
                {
                    cnp.Remove(8);
                    B9.Content = "0";
                    B9.IsEnabled = false;

                }


            }
            if (B5.Content == "X" && p == 0)
            {
                p = 1;
                cnp.Remove(4);

                Random rand = new Random();
                int randIndex = rand.Next(cnp.Count);
                int random = cnp[randIndex];
                if (random == 0)
                {
                    cnp.Remove(0);
                    B1.Content = "0";
                    B1.IsEnabled = false;

                }
                if (random == 1)
                {
                    cnp.Remove(1);
                    B2.Content = "0";
                    B2.IsEnabled = false;

                }
                if (random == 2)
                {
                    cnp.Remove(2);
                    B3.Content = "0";
                    B3.IsEnabled = false;

                }
                if (random == 3)
                {
                    cnp.Remove(3);
                    B4.Content = "0";
                    B4.IsEnabled = false;

                }
 
                if (random == 5)
                {
                    cnp.Remove(5);
                    B6.Content = "0";
                    B6.IsEnabled = false;

                }
                if (random == 6)
                {
                    cnp.Remove(6);
                    B7.Content = "0";
                    B7.IsEnabled = false;

                }
                if (random == 7)
                {
                    cnp.Remove(7);
                    B8.Content = "0";
                    B8.IsEnabled = false;

                }
                if (random == 8)
                {
                    cnp.Remove(8);
                    B9.Content = "0";
                    B9.IsEnabled = false;

                }


            }
            if (B6.Content == "X" && p == 0)
            {
                p = 1;
                cnp.Remove(5);

                Random rand = new Random();
                int randIndex = rand.Next(cnp.Count);
                int random = cnp[randIndex];
                if (random == 0)
                {
                    cnp.Remove(0);
                    B1.Content = "0";
                    B1.IsEnabled = false;

                }
                if (random == 1)
                {
                    cnp.Remove(1);
                    B2.Content = "0";
                    B2.IsEnabled = false;

                }
                if (random == 2)
                {
                    cnp.Remove(2);
                    B3.Content = "0";
                    B3.IsEnabled = false;

                }
                if (random == 3)
                {
                    cnp.Remove(2);
                    B4.Content = "0";
                    B4.IsEnabled = false;

                }
                if (random == 4)
                {
                    cnp.Remove(4);
                    B5.Content = "0";
                    B5.IsEnabled = false;

                }

                if (random == 6)
                {
                    cnp.Remove(6);
                    B7.Content = "0";
                    B7.IsEnabled = false;

                }
                if (random == 7)
                {
                    cnp.Remove(7);
                    B8.Content = "0";
                    B8.IsEnabled = false;

                }
                if (random == 8)
                {
                    cnp.Remove(8);
                    B9.Content = "0";
                    B9.IsEnabled = false;

                }


            }
            if (B7.Content == "X" && p == 0)
            {
                p = 1;
                cnp.Remove(6);

                Random rand = new Random();
                int randIndex = rand.Next(cnp.Count);
                int random = cnp[randIndex];
                if (random == 0)
                {
                    cnp.Remove(0);
                    B1.Content = "0";
                    B1.IsEnabled = false;

                }
                if (random == 1)
                {
                    cnp.Remove(1);
                    B2.Content = "0";
                    B2.IsEnabled = false;

                }
                if (random == 2)
                {
                    cnp.Remove(2);
                    B3.Content = "0";
                    B3.IsEnabled = false;

                }
                if (random == 3)
                {
                    cnp.Remove(3);
                    B4.Content = "0";
                    B4.IsEnabled = false;

                }
                if (random == 4)
                {
                    cnp.Remove(4);
                    B5.Content = "0";
                    B5.IsEnabled = false;

                }
                if (random == 5)
                {
                    cnp.Remove(5);
                    B6.Content = "0";
                    B6.IsEnabled = false;

                }

                if (random == 7)
                {
                    cnp.Remove(7);
                    B8.Content = "0";
                    B8.IsEnabled = false;

                }
                if (random == 8)
                {
                    cnp.Remove(8);
                    B9.Content = "0";
                    B9.IsEnabled = false;

                }


            }
            if (B8.Content == "X" && p == 0)
            {
                p = 1;
                cnp.Remove(7);

                Random rand = new Random();
                int randIndex = rand.Next(cnp.Count);
                int random = cnp[randIndex];
                if (random == 0)
                {
                    cnp.Remove(0);
                    B1.Content = "0";
                    B1.IsEnabled = false;

                }
                if (random == 1)
                {
                    cnp.Remove(1);
                    B2.Content = "0";
                    B2.IsEnabled = false;

                }
                if (random == 2)
                {
                    cnp.Remove(2);
                    B3.Content = "0";
                    B3.IsEnabled = false;

                }
                if (random == 3)
                {
                    cnp.Remove(3);
                    B4.Content = "0";
                    B4.IsEnabled = false;

                }
                if (random == 4)
                {
                    cnp.Remove(4);
                    B5.Content = "0";
                    B5.IsEnabled = false;

                }
                if (random == 5)
                {
                    cnp.Remove(5);
                    B6.Content = "0";
                    B6.IsEnabled = false;

                }
                if (random == 6)
                {
                    cnp.Remove(6);
                    B7.Content = "0";
                    B7.IsEnabled = false;

                }
                if (random == 8)
                {
                    cnp.Remove(8);
                    B9.Content = "0";
                    B9.IsEnabled = false;

                }


            }
            if (B9.Content == "X" && p == 0)
            {
                p = 1;
                cnp.Remove(8);

                Random rand = new Random();
                int randIndex = rand.Next(cnp.Count);
                int random = cnp[randIndex];
                if (random == 0)
                {
                    cnp.Remove(0);
                    B1.Content = "0";
                    B1.IsEnabled = false;

                }
                if (random == 1)
                {
                    cnp.Remove(1);
                    B2.Content = "0";
                    B2.IsEnabled = false;

                }
                if (random == 2)
                {
                    cnp.Remove(1);
                    B3.Content = "0";
                    B3.IsEnabled = false;

                }
                if (random == 3)
                {
                    cnp.Remove(2);
                    B4.Content = "0";
                    B4.IsEnabled = false;

                }
                if (random == 4)
                {
                    cnp.Remove(4);
                    B5.Content = "0";
                    B5.IsEnabled = false;

                }
                if (random == 5)
                {
                    cnp.Remove(5);
                    B6.Content = "0";
                    B6.IsEnabled = false;

                }
                if (random == 6)
                {
                    cnp.Remove(6);
                    B7.Content = "0";
                    B7.IsEnabled = false;

                }
                if (random == 7)
                {
                    cnp.Remove(7);
                    B8.Content = "0";
                    B8.IsEnabled = false;

                }



            }

        }

        private void C1(object sender, RoutedEventArgs e)
        {
            B1.Content = "X";
            B1.IsEnabled = false;
            //cnp.Remove(B1);
            Win();
            Robi();
        }


        private void C2(object sender, RoutedEventArgs e)
        {
            B2.Content = "X";
            B2.IsEnabled = false;
            // J.Remove(B1);
            Win();
            Robi();
        }

        private void C3(object sender, RoutedEventArgs e)
        {
            B3.Content = "X";
            B3.IsEnabled = false;
            // cnp.Remove(B1);
            Win();
            Robi();
        }

        private void C4(object sender, RoutedEventArgs e)
        {
            B4.Content = "X";
            B4.IsEnabled = false;
            // cnp.Remove(B1);
            Win();
            Robi();
        }

        private void C5(object sender, RoutedEventArgs e)
        {
            B5.Content = "X";
            B5.IsEnabled = false;
            //cnp.Remove(B1);
            Win();
            Robi();
        }

        private void C6(object sender, RoutedEventArgs e)
        {
            B6.Content = "X";
            B6.IsEnabled = false;
            // cnp.Remove(B1);
            Win();
            Robi();
        }

        private void C7(object sender, RoutedEventArgs e)
        {
            B7.Content = "X";
            B7.IsEnabled = false;
            //cnp.Remove(B1);
            Win();
            Robi();
        }

        private void C8(object sender, RoutedEventArgs e)
        {
            B8.Content = "X";
            B8.IsEnabled = false;
            // cnp.Remove(B1);
            Win();
            Robi();
        }

        private void C9(object sender, RoutedEventArgs e)
        {
            B9.Content = "X";
            B9.IsEnabled = false;
            // cnp.Remove(B1);
            Win();
            Robi();


        }
        private void Win()
        {
            if(B1.Content == "X" && B1.Content == B2.Content && B2.Content == B3.Content)
            {
                MessageBox.Show("Победа X");
                B1.IsEnabled = false;
                B2.IsEnabled = false;
                B3.IsEnabled = false;
                B4.IsEnabled = false;
                B5.IsEnabled = false;
                B6.IsEnabled = false;
                B7.IsEnabled = false;
                B8.IsEnabled = false;
                B9.IsEnabled = false;
            }
            if (B4.Content == "X" && B4.Content == B5.Content && B5.Content == B6.Content)
            {
                MessageBox.Show("Победа X");
                B1.IsEnabled = false;
                B2.IsEnabled = false;
                B3.IsEnabled = false;
                B4.IsEnabled = false;
                B5.IsEnabled = false;
                B6.IsEnabled = false;
                B7.IsEnabled = false;
                B8.IsEnabled = false;
                B9.IsEnabled = false;
            }
            if (B7.Content == "X" && B7.Content == B8.Content && B8.Content == B9.Content)
            {
                MessageBox.Show("Победа X");
                B1.IsEnabled = false;
                B2.IsEnabled = false;
                B3.IsEnabled = false;
                B4.IsEnabled = false;
                B5.IsEnabled = false;
                B6.IsEnabled = false;
                B7.IsEnabled = false;
                B8.IsEnabled = false;
                B9.IsEnabled = false;
            }
            if (B1.Content == "X" && B1.Content == B4.Content && B4.Content == B7.Content)
            {
                MessageBox.Show("Победа X");
                B1.IsEnabled = false;
                B2.IsEnabled = false;
                B3.IsEnabled = false;
                B4.IsEnabled = false;
                B5.IsEnabled = false;
                B6.IsEnabled = false;
                B7.IsEnabled = false;
                B8.IsEnabled = false;
                B9.IsEnabled = false;
            }
            if (B2.Content == "X" && B2.Content == B5.Content && B5.Content == B8.Content)
            {
                MessageBox.Show("Победа X");
                B1.IsEnabled = false;
                B2.IsEnabled = false;
                B3.IsEnabled = false;
                B4.IsEnabled = false;
                B5.IsEnabled = false;
                B6.IsEnabled = false;
                B7.IsEnabled = false;
                B8.IsEnabled = false;
                B9.IsEnabled = false;
            }
            if (B3.Content == "X" && B3.Content == B6.Content && B6.Content == B9.Content)
            {
                MessageBox.Show("Победа X");
                B1.IsEnabled = false;
                B2.IsEnabled = false;
                B3.IsEnabled = false;
                B4.IsEnabled = false;
                B5.IsEnabled = false;
                B6.IsEnabled = false;
                B7.IsEnabled = false;
                B8.IsEnabled = false;
                B9.IsEnabled = false;
            }
            if (B1.Content == "X" && B1.Content == B5.Content && B5.Content == B9.Content)
            {
                MessageBox.Show("Победа X");
                B1.IsEnabled = false;
                B2.IsEnabled = false;
                B3.IsEnabled = false;
                B4.IsEnabled = false;
                B5.IsEnabled = false;
                B6.IsEnabled = false;
                B7.IsEnabled = false;
                B8.IsEnabled = false;
                B9.IsEnabled = false;
            }
            if (B3.Content == "X" && B3.Content == B5.Content && B5.Content == B7.Content)
            {
                MessageBox.Show("Победа X");
                B1.IsEnabled = false;
                B2.IsEnabled = false;
                B3.IsEnabled = false;
                B4.IsEnabled = false;
                B5.IsEnabled = false;
                B6.IsEnabled = false;
                B7.IsEnabled = false;
                B8.IsEnabled = false;
                B9.IsEnabled = false;
            }
            if (B1.Content == "0" && B1.Content == B2.Content && B2.Content == B3.Content)
            {
                MessageBox.Show("Победа 0");
                B1.IsEnabled = false;
                B2.IsEnabled = false;
                B3.IsEnabled = false;
                B4.IsEnabled = false;
                B5.IsEnabled = false;
                B6.IsEnabled = false;
                B7.IsEnabled = false;
                B8.IsEnabled = false;
                B9.IsEnabled = false;
            }
            if (B4.Content == "0" && B4.Content == B5.Content && B5.Content == B6.Content)
            {
                MessageBox.Show("Победа 0");
                B1.IsEnabled = false;
                B2.IsEnabled = false;
                B3.IsEnabled = false;
                B4.IsEnabled = false;
                B5.IsEnabled = false;
                B6.IsEnabled = false;
                B7.IsEnabled = false;
                B8.IsEnabled = false;
                B9.IsEnabled = false;
            }
            if (B7.Content == "0" && B7.Content == B8.Content && B8.Content == B9.Content)
            {
                MessageBox.Show("Победа 0");
                B1.IsEnabled = false;
                B2.IsEnabled = false;
                B3.IsEnabled = false;
                B4.IsEnabled = false;
                B5.IsEnabled = false;
                B6.IsEnabled = false;
                B7.IsEnabled = false;
                B8.IsEnabled = false;
                B9.IsEnabled = false;
            }
            if (B1.Content == "0" && B1.Content == B4.Content && B4.Content == B7.Content)
            {
                MessageBox.Show("Победа 0");
                B1.IsEnabled = false;
                B2.IsEnabled = false;
                B3.IsEnabled = false;
                B4.IsEnabled = false;
                B5.IsEnabled = false;
                B6.IsEnabled = false;
                B7.IsEnabled = false;
                B8.IsEnabled = false;
                B9.IsEnabled = false;
            }
            if (B2.Content == "0" && B2.Content == B5.Content && B5.Content == B8.Content)
            {
                MessageBox.Show("Победа 0");
                B1.IsEnabled = false;
                B2.IsEnabled = false;
                B3.IsEnabled = false;
                B4.IsEnabled = false;
                B5.IsEnabled = false;
                B6.IsEnabled = false;
                B7.IsEnabled = false;
                B8.IsEnabled = false;
                B9.IsEnabled = false;
            }
            if (B3.Content == "0" && B3.Content == B6.Content && B6.Content == B9.Content)
            {
                MessageBox.Show("Победа 0");
                B1.IsEnabled = false;
                B2.IsEnabled = false;
                B3.IsEnabled = false;
                B4.IsEnabled = false;
                B5.IsEnabled = false;
                B6.IsEnabled = false;
                B7.IsEnabled = false;
                B8.IsEnabled = false;
                B9.IsEnabled = false;
            }
            if (B1.Content == "0" && B1.Content == B5.Content && B5.Content == B9.Content)
            {
                MessageBox.Show("Победа 0");
                B1.IsEnabled = false;
                B2.IsEnabled = false;
                B3.IsEnabled = false;
                B4.IsEnabled = false;
                B5.IsEnabled = false;
                B6.IsEnabled = false;
                B7.IsEnabled = false;
                B8.IsEnabled = false;
                B9.IsEnabled = false;
            }
            if (B3.Content == "0" && B3.Content == B5.Content && B5.Content == B7.Content)
            {
                MessageBox.Show("Победа 0");
                B1.IsEnabled = false;
                B2.IsEnabled = false;
                B3.IsEnabled = false;
                B4.IsEnabled = false;
                B5.IsEnabled = false;
                B6.IsEnabled = false;
                B7.IsEnabled = false;
                B8.IsEnabled = false;
                B9.IsEnabled = false;
            }
        }
    }
}
