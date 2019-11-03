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
using System.Windows.Shapes;
using pets.Models;

namespace pets
{
    /// <summary>
    /// Interaction logic for PetForm.xaml
    /// </summary>
    public partial class PetForm : Window
    {

        public PetForm()
        {
            InitializeComponent();
        }
        private void AddPet(object sender, RoutedEventArgs e)
        {
            String name = Name.Text;
            int age = Int32.Parse(Age.Text);
            int size = Int32.Parse(Size.Text);
            int type = Int32.Parse(Type.Text);
            String breed = Breed.Text;
            String description = Description.Text;
            String sex = Sex.Text;
            EntAnimal animal = new EntAnimal();
            animal.name = name;
            animal.age = age;
            animal.sizeId = size;
            animal.typeId = type;
            animal.breed = breed;
            animal.description = description;
            animal.sex = sex;
            PetsContext context = new PetsContext();
            context.Animals.Add(animal);
            context.SaveChanges();
        }
    }
}
