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

namespace WpfApp1
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

        private void CalculateButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (!(string.IsNullOrEmpty(HeightTextbox.Text)) && !(string.IsNullOrEmpty(WeightTextbox.Text)) && (WomanButton.IsChecked == true || ManButton.IsChecked == true))
            {
                int height;
                int weight;
                bool isheight = int.TryParse(HeightTextbox.Text, out height);
                bool isweight = int.TryParse(WeightTextbox.Text, out weight);
                while (true)
                {
                    if (isheight && isweight)
                    {
                        if (height == Convert.ToDouble(HeightTextbox.Text) && weight == Convert.ToDouble(WeightTextbox.Text))
                        {
                            if (height < 130 || height > 220)
                            {
                                MessageBox.Show("Ошибка: рост должен быть в диапазоне от 130 до 220 см");
                                break;
                            }
                            if (weight < 40 || weight > 170)
                            {
                                MessageBox.Show("Ошибка: вес должен быть в диапазоне от 40 до 170 кг");
                                break;
                            }
                            else
                            {
                                if (WomanButton.IsChecked == true)
                                {
                                    double normalweight;
                                    normalweight = height - 100 - (height * 0.10);
                                    if (normalweight == weight)
                                    {
                                        double TextWeightCom = normalweight - weight;
                                        WeightOptimal.Text = Convert.ToString(normalweight);
                                        WeightComparison.Text = Convert.ToString(TextWeightCom);
                                        MessageBox.Show("Вес в норме");
                                        break;
                                    }
                                    else if (normalweight > weight)
                                    {
                                        double TextWeightCom = normalweight - weight;
                                        WeightOptimal.Text = Convert.ToString(normalweight);
                                        WeightComparison.Text = Convert.ToString(TextWeightCom);
                                        MessageBox.Show($"Ваш вес ниже нормы примерно на {normalweight - weight} кг");
                                        break;
                                    }
                                    else
                                    {
                                        double TextWeightCom = normalweight - weight;
                                        WeightOptimal.Text = Convert.ToString(normalweight);
                                        WeightComparison.Text = Convert.ToString(TextWeightCom);
                                        MessageBox.Show($"Ваш вес выше нормы примерно на {weight - normalweight} кг");
                                        break;
                                    }
                                }
                                else if (ManButton.IsChecked == true)
                                {
                                    double normalweight;
                                    normalweight = height - 100 + (height * 0.13);
                                    if (normalweight == weight)
                                    {
                                        double TextWeightCom = normalweight - weight;
                                        WeightOptimal.Text = Convert.ToString(normalweight);
                                        WeightComparison.Text = Convert.ToString(TextWeightCom);
                                        MessageBox.Show("Вес в норме");
                                        break;
                                    }
                                    else if (normalweight > weight)
                                    {
                                        double TextWeightCom = normalweight - weight;
                                        WeightOptimal.Text = Convert.ToString(normalweight);
                                        WeightComparison.Text = Convert.ToString(TextWeightCom);
                                        MessageBox.Show($"Ваш вес ниже нормы примерно на {normalweight - weight} кг");
                                        break;
                                    }
                                    else
                                    {
                                        double TextWeightCom = normalweight - weight;
                                        WeightOptimal.Text = Convert.ToString(normalweight);
                                        WeightComparison.Text = Convert.ToString(TextWeightCom);
                                        MessageBox.Show($"Ваш вес выше нормы примерно на {weight - normalweight} кг");
                                        break;
                                    }
                                }
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Что-то не так..");
                        break;
                    }
                }
            }
            else if (WomanButton.IsChecked == false && ManButton.IsChecked == false)
            {
                MessageBox.Show("Ошибка! Похоже вы не выбрали пол");
            }
            else if (HeightTextbox.Text == "" && WeightTextbox.Text == "")
            {
                MessageBox.Show("Ошибка! Похоже вы не заполнили поля роста и веса");
            }
            else if (HeightTextbox.Text == "")
            {
                MessageBox.Show("Ошибка! Похоже вы не заполнили поле роста");
            }
            else if (WeightTextbox.Text == "")
            {
                MessageBox.Show("Ошибка! Похоже вы не заполнили поле веса");
            }
            }

        private void WomanButton_Checked(object sender, RoutedEventArgs e)
        {
            WeightOptimal.Text = "";
            WeightComparison.Text = "";
        }

        private void ManButton_Checked(object sender, RoutedEventArgs e)
        {
            WeightOptimal.Text = "";
            WeightComparison.Text = "";
        }

        private void HeightTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            WeightOptimal.Text = "";
            WeightComparison.Text = "";
        }

        private void WeightTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            WeightOptimal.Text = "";
            WeightComparison.Text = "";
        }
    }
}
