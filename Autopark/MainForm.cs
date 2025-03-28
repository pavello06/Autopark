using System.Reflection;

namespace Autopark
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Program.Cars = new CarTypes.Cars(autoparkFlowLayoutPanel);
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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Serializarion.Serialization.Deserialize(openFileDialog.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Serializarion.Serialization.Serialize(saveFileDialog.FileName);
            }
        }

        private void addClassButton_Click(object sender, EventArgs e)
        {
            if (openFileDialogDll.ShowDialog() == DialogResult.OK)
            {
                Assembly.LoadFrom(openFileDialogDll.FileName);
            }
        }
    }
}