using Autopark.Car.Regular;

namespace Autopark
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();
            addForm.ShowDialog();
        }
    }
}
