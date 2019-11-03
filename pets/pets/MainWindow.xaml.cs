using pets.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace pets
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PetsContext db;
        public MainWindow()
        {
            InitializeComponent();

            db = new PetsContext();
            db.Animals.Load();
            animalsGrid.ItemsSource = db.Animals.Local.ToBindingList();

            this.Closing += MainWindow_Closing;
        }

        private void AddPet(object sender, RoutedEventArgs e)
        {
            PetForm petForm = new PetForm();
            petForm.ShowDialog();
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }
    }
}
