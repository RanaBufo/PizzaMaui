
using CommunityToolkit.Mvvm.ComponentModel;
using PizzaMobile.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PizzaMobile.ViewModel
{
    public partial class PizzaViewModel : ObservableObject
    {
        public List<Pizza> Pizzas { get; set; }

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool isBusy;
        [ObservableProperty]
        string title;
        public bool IsNotBusy => !isBusy;

        public PizzaViewModel()
        {
            // Загрузите данные из файла JSON
            string jsonFilePath = "DB//Pizza.json";// Уточните путь к файлу
            string jsonContent = File.ReadAllText(jsonFilePath);

            // Десериализуйте данные JSON в объект PizzaData
            Pizzas = JsonSerializer.Deserialize<List<Pizza>>(jsonContent) ?? new List<Pizza>();

        }
    }
}
