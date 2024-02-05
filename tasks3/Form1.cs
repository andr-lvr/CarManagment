using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace CarManagementApp
{
    public partial class Form1 : Form
    {
        private List<Car> cars = new List<Car>();

        // Популярні бренди та їх моделі
        private Dictionary<string, List<string>> popularBrandsAndModels = new Dictionary<string, List<string>>
        {
            {"Toyota", new List<string>{"Camry", "Corolla", "Rav4"}},
            {"Honda", new List<string>{"Accord", "Civic", "CR-V"}},
            {"Ford", new List<string>{"F-150", "Escape", "Focus"}},
            {"Chevrolet", new List<string>{"Silverado", "Malibu", "Equinox"}},
            {"Nissan", new List<string>{"Altima", "Sentra", "Rogue"}},
            {"BMW", new List<string>{"3 Series", "5 Series", "X5"}},
            {"Mercedes-Benz", new List<string>{"C-Class", "E-Class", "GLC-Class"}},
            {"Audi", new List<string>{"A4", "Q5", "A6"}},
            {"Hyundai", new List<string>{"Elantra", "Sonata", "Tucson"}},
            {"Kia", new List<string>{"Optima", "Sorento", "Sportage"}}
        };

        public Form1()
        {
            InitializeComponent();

            // Додати популярні бренди до комбо боксу
            cmbBrand.Items.AddRange(popularBrandsAndModels.Keys.ToArray());
            cmbSearchBrand.Items.AddRange(popularBrandsAndModels.Keys.ToArray());
        }

        public class Car
        {
            [Required(ErrorMessage = "Brand is required")]
            public string Brand { get; set; }

            [Required(ErrorMessage = "Model is required")]
            public string Model { get; set; }

            [Required(ErrorMessage = "Color is required")]
            public string Color { get; set; }

            [Range(1900, 3000, ErrorMessage = "Year must be between 1900 and 3000")]
            public int Year { get; set; }

            [Required(ErrorMessage = "License plate is required")]
            [RegularExpression(@"^[A-Z0-9-]*$", ErrorMessage = "License plate must contain only uppercase letters, digits, and dashes")]
            public string LicensePlate { get; set; }

            [Required(ErrorMessage = "VIN number is required")]
            [RegularExpression(@"^[A-Z0-9]{17}$", ErrorMessage = "VIN must be 17 characters long and contain only uppercase letters and digits")]
            public string VIN { get; set; }

            public override string ToString()
            {
                return $"{Year} {Brand} {Model} - {Color} ({LicensePlate})";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Car newCar = new Car
            {
                Brand = cmbBrand.Text,
                Model = cmbModel.Text,
                Color = cmbColor.SelectedItem.ToString(),
                Year = Convert.ToInt32(nudYear.Value),
                LicensePlate = txtLicensePlate.Text,
                VIN = txtVIN.Text
            };

            cars.Add(newCar);
            listBoxCars.Items.Add(newCar);

            // Додати бренд та модель до пошукових комбо боксів
            AddBrandAndModelToSearchComboBoxes(newCar.Brand, newCar.Model);

            // Оновити комбо бокс для моделей у додаванні
            UpdateModelComboBox();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxCars.SelectedItem != null)
            {
                Car selectedCar = (Car)listBoxCars.SelectedItem;
                cars.Remove(selectedCar);
                listBoxCars.Items.Remove(selectedCar);
            }
            else
            {
                MessageBox.Show("Please select a car to remove.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate the ComboBox with unique brand names
            foreach (var car in cars)
            {
                AddBrandAndModelToSearchComboBoxes(car.Brand, car.Model);
            }

            // Додати моделі першого бренду до комбо боксу
            UpdateModelComboBox();
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBrand = cmbBrand.SelectedItem.ToString();
            cmbModel.Items.Clear();

            if (popularBrandsAndModels.ContainsKey(selectedBrand))
            {
                cmbModel.Items.AddRange(popularBrandsAndModels[selectedBrand].ToArray());
            }
        }

        private void cmbSearchBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBrand = cmbSearchBrand.SelectedItem.ToString();
            cmbSearchModel.Items.Clear();

            if (popularBrandsAndModels.ContainsKey(selectedBrand))
            {
                cmbSearchModel.Items.AddRange(popularBrandsAndModels[selectedBrand].ToArray());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedBrand = cmbSearchBrand.SelectedItem?.ToString();
            string selectedModel = cmbSearchModel.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedBrand) && !string.IsNullOrEmpty(selectedModel))
            {
                // Find the car with the selected brand and model
                Car foundCar = cars.Find(car => car.Brand == selectedBrand && car.Model == selectedModel);

                if (foundCar != null)
                {
                    MessageBox.Show($"Car found:\n{foundCar}");
                }
                else
                {
                    MessageBox.Show("Car not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select both brand and model to search.");
            }
        }

        private void AddBrandAndModelToSearchComboBoxes(string brand, string model)
        {
            if (!cmbSearchBrand.Items.Contains(brand))
            {
                cmbSearchBrand.Items.Add(brand);
            }

            if (!cmbSearchModel.Items.Contains(model))
            {
                cmbSearchModel.Items.Add(model);
            }
        }

        private void UpdateModelComboBox()
        {
            string selectedBrand = cmbBrand.SelectedItem?.ToString();
            cmbModel.Items.Clear();

            if (selectedBrand != null && popularBrandsAndModels.ContainsKey(selectedBrand))
            {
                cmbModel.Items.AddRange(popularBrandsAndModels[selectedBrand].ToArray());
            }
        }
    }
}
