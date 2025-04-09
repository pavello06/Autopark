using Autopark.Serialization;
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
                Serialization.Serialization.Deserialize(openFileDialog.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Serialization.Serialization.Serialize(saveFileDialog.FileName);
            }
        }

        private void addClassButton_Click(object sender, EventArgs e)
        {
            if (openFileDialogDll.ShowDialog() == DialogResult.OK)
            {
                Assembly.LoadFrom(openFileDialogDll.FileName);
            }
        }

        private void addActionButton_Click(object sender, EventArgs e)
        {
            if (openFileDialogDll.ShowDialog() == DialogResult.OK)
            {
                Assembly.LoadFrom(openFileDialogDll.FileName);

                System.Type[] allTypes = Type.Type.GetTypes();
                var baseType = typeof(IProcess);
                foreach (var type in allTypes)
                {
                    if (!type.IsInterface && baseType.IsAssignableFrom(type))
                    {
                        Serialization.Serialization.extraSerialize = (Serialization.Serialization.ExtraSerialize)type.GetMethod("Serialize")!.CreateDelegate(typeof(Serialization.Serialization.ExtraSerialize));
                        Serialization.Serialization.extraDeserialize = (Serialization.Serialization.ExtraDeserialize)type.GetMethod("Deserialize")!.CreateDelegate(typeof(Serialization.Serialization.ExtraDeserialize));
                    }
                }
            }
        }
    }
}