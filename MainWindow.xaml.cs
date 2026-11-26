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

namespace KachalinSV_1_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Pitanie> list_Obj = new List<Pitanie>(); //Массив из обьектов класса Pitanie
        public static List<Chocolate> list_Obj2 = new List<Chocolate>(); //Массив из обьектов класса Cholocate

        public static List<string> list2 = new List<string>() {};//Массив который соддержит строки данных обьектов для подключения к ListView через ItemsSource
        public MainWindow()
        {
            InitializeComponent();
            list1.ItemsSource = list2;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (textbox1.Text.Length != 0 || textbox2.Text.Length != 0 || textbox3.Text.Length != 0)//Проверка на пустоту строк
                {
                    float d1 = Convert.ToSingle(textbox2.Text);
                    float d2 = Convert.ToSingle(textbox3.Text);
                    if(d1 < 0 || d2 < 0)
                    {
                        MessageBox.Show("Минусовое число");
                        return;
                    }

                    if(Convert.ToBoolean(checkbox.IsChecked))
                    {
                        if(textbox4.Text.Length == 0)
                        {
                            MessageBox.Show("Пустые строки");
                        }
                        float d3 = Convert.ToSingle(textbox4.Text);
                        Chocolate obj = new Chocolate(textbox1.Text,d1,d2,d3);
                        list_Obj2.Add(obj);
                        list2.Add(obj.Info());
                    }
                    else
                    {
                        Pitanie obj = new Pitanie(textbox1.Text, d1, d2);
                        list_Obj.Add(obj);
                        list2.Add(obj.Info());
                    }
                    list1.ItemsSource = null;
                    list1.ItemsSource = list2;
                    textbox1.Text = "";
                    textbox2.Text = "";
                    textbox3.Text = "";
                    textbox4.Text = "";
                }
                else
                {
                    MessageBox.Show("Пустые строки");
                }
            }
            catch
            {
                MessageBox.Show("Вы ввели не тот тип данных");
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            textbox4.IsEnabled = Convert.ToBoolean(checkbox.IsChecked);
        }
    }
}
