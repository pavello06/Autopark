using Autopark.Objects.Regular;

namespace Autopark
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Program.Cars = new Objects.Cars(autoparkFlowLayoutPanel);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {

            Program.Cars!.Undo();

        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            Program.Cars!.Redo();
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.File.Deserialize("user.json");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.File.Serialize("user.json");
        }
    }
}