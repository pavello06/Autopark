using Autopark.Car.Regular;

namespace Autopark
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Program.Cars = new Car.Cars(autoparkFlowLayoutPanel);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void autoparkFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void autoparkFlowLayoutPanel_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            Program.Cars.Undo();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            Program.Cars.Redo();
        }
    }
}