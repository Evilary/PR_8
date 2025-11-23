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
using PR_8.Chernyshkov.Classes;

namespace PR_8.Chernyshkov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LiteVoin lightWarrior;
        private ProVoin heavyWarrior;
        public MainWindow()
        {
            InitializeComponent();

            lightWarrior = new LiteVoin("Алексей", 100);
            heavyWarrior = new ProVoin("Иван", 100);

            
            UpdateWarriorInfo();

        }
        private void UpdateWarriorInfo()
        {
            LightInfo.Text = $"Легкий воин\nЗдоровье: {lightWarrior.Health}/{lightWarrior.MaxHealth}";
            HeavyInfo.Text = $"Тяжелый воин\nЗдоровье: {heavyWarrior.Health}/{heavyWarrior.MaxHealth}";
        }

        private void BtnLight_Click(object sender, RoutedEventArgs e)
        {
            lightWarrior.TakeDamage(20);
            UpdateWarriorInfo();
            lightWarrior.ShowInfo();
        }

        private void BtnHeavy_Click(object sender, RoutedEventArgs e)
        {
            heavyWarrior.TakeDamage(20);
            UpdateWarriorInfo();
            heavyWarrior.ShowInfo();
        }


    }
}
