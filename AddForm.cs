using Autopark.Objects;
using System.Reflection;

namespace Autopark
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();

            AddCarTypes();
        }

        private void AddCarTypes()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var allTypes = assembly.GetTypes();

            var baseClassType = typeof(CarCreator);

            foreach (var type in allTypes)
            {
                if (type != baseClassType && baseClassType.IsAssignableFrom(type))
                {
                    carTypeComboBox.Items.Add(type.Name);
                }
            }
        }

        private void carTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var carCreatorType = assembly.GetType($"Autopark.Objects.{carTypeComboBox.SelectedItem}");

            var carCreatorInstance = Activator.CreateInstance(carCreatorType);
            var carTypeField = carCreatorType.GetField("CarType", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            var carType = (Type?)carTypeField!.GetValue(carCreatorInstance);

            fieldsFlowLayoutPanel.Controls.Clear();
            AddCarFields(carType);
        }

        private void AddCarFields(Type? type)
        {
            if (type!.BaseType != typeof(Objects.Car).BaseType)
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
            addButton.Enabled = CanAdd();
        }

        private bool CanAdd()
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

        private void addButton_Click(object sender, EventArgs e)
        {
            var fields = new object[fieldsFlowLayoutPanel.Controls.Count];
            for (int i = 0; i < fields.Length; i++)
            {
                fields[i] = ((TextBox)fieldsFlowLayoutPanel.Controls[i]).Text;
            }

            var assembly = Assembly.GetExecutingAssembly();
            var carCreatorType = assembly.GetType($"Autopark.Objects.{carTypeComboBox.SelectedItem}");

            Program.Cars!.Add(((CarCreator)Activator.CreateInstance(carCreatorType))!.Create(fields));

            this.Close();
        }
    }
}