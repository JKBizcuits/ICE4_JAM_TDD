using System;
using System.IO;
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

namespace ICE4_JAM_TDD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            try
            {

                StreamWriter sw = new StreamWriter("courses.txt");

                sw.WriteLine("Visual Programming");

                sw.WriteLine("The Object Oriented Paradigm");

                sw.WriteLine("Data Communications and Computer Networks");

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            try
            {

                StreamWriter sw = new StreamWriter("presidents.txt");

                sw.Write("Washington ");

                sw.Write("Adams ");

                sw.WriteLine("Jefferson");

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            /* try
             {

                 StreamWriter sw = new StreamWriter("produce.txt", true);

                 sw.WriteLine("");

                 sw.WriteLine("parsley");

                 sw.WriteLine("onions");

                 sw.WriteLine("tomatoes");

                 sw.Close();
             }
             catch (Exception e)
             {
                 Console.WriteLine("Exception: " + e.Message);
             }
             finally
             {
                 Console.WriteLine("Executing finally block.");
             }*/
        
             StreamReader file = new StreamReader("months.csv");

             MessageBox.Show(file.ReadLine(), "First month", MessageBoxButton.OK);
             MessageBox.Show(file.ReadLine(), "Second month", MessageBoxButton.OK);
             MessageBox.Show(file.ReadLine(), "Third month", MessageBoxButton.OK);

             file.Close();


            StreamReader file2 = new StreamReader("months.csv");

            MonthsTextBlock.Text = file2.ReadLine() + " ";
            MonthsTextBlock.Text += file2.ReadLine() + " ";
            MonthsTextBlock.Text += file2.ReadLine();

            file2.Close();

            try
            {
                StreamReader file3 = new StreamReader("prices.txt");
                double E1 = Convert.ToDouble(file3.ReadLine());
                double E2 = Convert.ToDouble(file3.ReadLine());
                double E3 = Convert.ToDouble(file3.ReadLine());
                double initSum = 0;
                double FirstSum = E1;
                double SecondSum = FirstSum + E2;
                double FinalSum = SecondSum + E3;


                MessageBox.Show("Initial Sum: " + initSum + ", Add: " + E1 + ", First Sum: " + FirstSum + ", Add: " + E2 + ", Second Sum: " + SecondSum + ", Add: " + E3 + ", Final Sum: " + FinalSum, "Running Total of Doubles", MessageBoxButton.OK);

                file3.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            try
            {

                StreamWriter sw = new StreamWriter("randomnumbers.txt");
                Random rnd = new Random();
                for(int i = 0; i<100; i++)
                {
                    sw.WriteLine(rnd.Next(1, 101));
                }
                

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            StreamReader file4 = new StreamReader("randomnumbers.txt");

            double sum = 0;
            RandomNumbersTextBlock.Text = "";
            for (int i = 0; i < 100; i++)
            {
                double number = Convert.ToDouble(file4.ReadLine());
                RandomNumbersTextBlock.Text += number + "\r\n";
                sum += number;
            }
            MessageBox.Show(Convert.ToString(sum), "Total of Random Numbers", MessageBoxButton.OK);

            file4.Close();


            StreamReader file5 = new StreamReader("records.txt");

            string[] Data = new string[] {"Kelley", "Robert", "12/25/69", "2001 Newburg Road", "Chief Cook and Bottle Washer"};
            string[] Temp = new string[5];
            string TwoWord = file5.ReadLine();
            MessageBox.Show(TwoWord, "Total of Random Numbers", MessageBoxButton.OK);
            string FirstWord;
            string SecondWord;
            FirstWord = TwoWord.Substring(0, 4);
            MessageBox.Show(TwoWord, "Total of Random Numbers", MessageBoxButton.OK);
            SecondWord = TwoWord.Substring(4, 4);
            Temp[0] = FirstWord + " " + SecondWord;
            TwoWord = file5.ReadLine();
            FirstWord = TwoWord.Substring(0, 5);
            SecondWord = TwoWord.Substring(5, 4);
            Temp[1] = FirstWord + " " + SecondWord;
            TwoWord = file5.ReadLine();
            FirstWord = TwoWord.Substring(0, 5);
            SecondWord = TwoWord.Substring(5, 4);
            Temp[2] = FirstWord + " " + SecondWord;
            Temp[3] = file5.ReadLine().Substring(0, 7);
            Temp[4] = file5.ReadLine();
            string final = "";
            for (int i = 0; i < 5; i++)
            {
                final += Temp[i] + ": " + Data[i] + "\r\n";
            }
            MessageBox.Show(final, "Total of Random Numbers", MessageBoxButton.OK);

            file5.Close();
        }

    }
}
