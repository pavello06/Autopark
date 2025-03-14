using Autopark.Car;
using System.Reflection;

namespace Autopark
{
    public partial class EditForm : Form
    {
        private Car.Car _car;

        internal EditForm(Car.Car car)
        {
            InitializeComponent();

            _car = car;
            AddCarFields(car.GetType());
        }

        private void AddCarFields(Type? type)
        {
            if (type!.BaseType != typeof(Object))
            {
                AddCarFields(type.BaseType);
            }

            foreach (var field in type.GetProperties())
            {
                if (type.BaseType != null && type.BaseType.GetProperty(field.Name, BindingFlags.Public | BindingFlags.Instance) != null)
                {
                    continue;
                }

                var textBox = new TextBox();
                textBox.Font = new Font("Segoe UI", 13.8F);
                textBox.PlaceholderText = field.Name;
                textBox.Size = new Size(fieldsFlowLayoutPanel.Width - 30, 40);
                textBox.TextChanged += textBox_TextChanged;

                fieldsFlowLayoutPanel.Controls.Add(textBox);
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            editButton.Enabled = CanEdit();
        }

        private bool CanEdit()
        {
            foreach (var control in fieldsFlowLayoutPanel.Controls)
            {
                if (((TextBox)control).Text.Length == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int i = 0;

            Type currentType = _car.GetType();
            var properties = new List<PropertyInfo>();

            while (currentType != null)
            {
                var currentProperties = currentType.GetProperties(
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly
                );

                properties.InsertRange(0, currentProperties);

                currentType = currentType.BaseType;
            }

            foreach (var property in properties)
            {
                if (i < fieldsFlowLayoutPanel.Controls.Count && fieldsFlowLayoutPanel.Controls[i] is TextBox textBox)
                {
                    object convertedValue;
                    if (property.PropertyType == typeof(Engine))
                    {
                        convertedValue = textBox.Text;
                        _car.ChangeEngine(new Car.Engine((EngineType)Enum.Parse(typeof(EngineType), ((string)convertedValue))));
                    }
                    else
                    {
                        convertedValue = Convert.ChangeType(textBox.Text, property.PropertyType);
                        property.SetValue(_car, convertedValue);
                    }

                    i++;
                }
            }

            Program.Cars.UpdateView();
            Program.Cars.UpdateHistory();

            this.Close();
        }
    }
}
