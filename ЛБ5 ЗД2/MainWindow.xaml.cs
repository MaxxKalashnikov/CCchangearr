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

namespace ЛБ5_ЗД2
{
    //Даны натуральное число a и символьный массив nums[a],в 
    //котором хранятся латинские буквы и арабские цифры.
    //Создайте символьный массив b, поместив в него только латинские буквы из массива nums.

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string letnum = "1234567890ABCDEFGHIJKLMNOPQRSTUVXYZabcdefghijklmnopqarstuvwxyz"; // объявляем строку, которая состоит из Латинского алфавита и арабских цифр
            char[] p = letnum.ToCharArray();//преобразуем данную строку в буквенно-символьный массив
            int a = int.Parse(textbox1.Text);
            char[] nums = new char[a];//вводим два вспомогательных массива
            char[] itog = new char[a];
            int ind = 0;
            int ind2 = 0;
            var random = new Random(DateTime.Now.Millisecond);//перемешиваем элементы массива в случайном порядке 
            p = p.OrderBy(x => random.Next()).ToArray();
            textbox2.Text += "Начальный массив:".ToString();
            for (int i = 0; i < a; i++)//заполняем наш начальный массив необходимым количеством элементов 
            {
                textbox2.Text += p[i].ToString();
                nums[ind] = p[i]; ind++;
            }
            if (ind!=0)//заполняем итоговый массив всеми элементами кроме цифр 
            {             
                for (int i = 0; i < ind; i++)
                {
                    if (nums[i] != '1' && nums[i] != '2' && nums[i] != '3' && nums[i] != '4' && nums[i] != '5' && nums[i] != '6' && nums[i] != '7' && nums[i] != '8' && nums[i] != '9' && nums[i] != '0')
                    {
                        itog[ind2] = nums[i]; ind2++;
                    }
                }
            }
            if (ind != 0)//выводим итоговый массив на экран 
            {
                textbox2.Text += "\nИтоговый массив:".ToString();
                for (int i = 0; i < ind2; i++)
                {
                    textbox2.Text += itog[i].ToString();
                }
            }
        }
   
    }
}
