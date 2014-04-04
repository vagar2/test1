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
using Microsoft.Win32;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btCalc_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }
        }

        private void btCalc2_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }
            myAL.Sort();
            lbMain.Items.Add("Отсортированный массив");
            foreach (int elem in myAL)
            {
                lbMain.Items.Add(elem);
            }
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog myDialog = new SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

            if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in lbMain.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            }
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btZad1_Click(object sender, RoutedEventArgs e)
        {
            //1. Дан массив из n чисел. Сколько элементов массива больше своих «соседей»,­ 
            //т.е. предыдущег­о и последующе­го. Первый и последний элементы не рассматрив­ать.
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }
            lbMain.Items.Add("Сколько элементов массива больше своих «соседей»,");
            lbMain.Items.Add("­т.е. предыдущег­о и последующе­го.");
            lbMain.Items.Add("­Первый и последний элементы не рассматрив­ать.");
            int resultoftask = 0;
            for (index = 1; index <= itemCount-2; index++)
            {
                int prevousVal = Convert.ToInt32(myAL[index - 1]);
                int currentVal = Convert.ToInt32(myAL[index]);
                int nextVal = Convert.ToInt32(myAL[index + 1]);
                if ((currentVal > prevousVal) && (currentVal>nextVal))
                {
                    resultoftask++;
                    lbMain.Items.Add(resultoftask+":" + prevousVal+" "+currentVal+" "+nextVal);
                }
            }
            lbMain.Items.Add("Ответ: "+resultoftask);
        }

        private void btZad2_Click(object sender, RoutedEventArgs e)
        {
            //2. Для массива из n чисел найти номер первого элемента, большего 25.
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }
            lbMain.Items.Add("2. Для массива из n чисел найти номер первого элемента, большего 25.");

            for (index = 0; index <= itemCount - 1; index++)
            {
                int currentVal = Convert.ToInt32(myAL[index]);
                if (currentVal > 25)
                {
                    lbMain.Items.Add("Число:" + currentVal);
                    lbMain.Items.Add("Ответ: " + (index+1));
                    break;
                }
            }
        }
    }
}
