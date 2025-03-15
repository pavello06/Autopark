using Autopark.Objects.Race;
using Autopark.Objects.Rare;
using Autopark.Objects.Regular;
using Autopark.Visualization;
using System.Text.Json.Serialization;

namespace Autopark.Objects
{
    internal abstract class Car : IVisualization
    {
        protected static uint count = 0;

        protected uint id;
        public string Brand { get; set; }
        public string Model { get; set;  }
        public uint Price { get; set; }
        public Engine Engine { get; set; }

        public Car(string brand, string model, uint price, EngineType type)
        {
            id = count;
            Brand = brand;
            Model = model;
            Price = price;
            Engine = new Engine(type);

            count++;
        }
        public Car()
        {

        }

        protected virtual void UpdatePrice(EngineType oldEngineType, EngineType newEngineType)
        {
            Price *= (uint)(Engine.PricesCoefficients[(int)newEngineType] / Engine.PricesCoefficients[(int)oldEngineType]);
        }

        public void ChangeEngine(Engine newEngine)
        {
            UpdatePrice(Engine.Type, newEngine.Type);
            Engine = newEngine;
        }

        public override string ToString()
        {
            return $"Brand: {Brand}; Model: {Model}; Price: {Price}; Engine: {Engine.ToString()}";
        }

        public virtual Panel Visualize()
        {
            var card = new Panel();
            card.AutoSize = true;
            card.Location = new Point(0, 0);
            card.BackColor = Color.Pink;

            var contextMenuStrip = new ContextMenuStrip();
            var editMenuItem = new ToolStripMenuItem("Edit");
            var deleteMenuItem = new ToolStripMenuItem("Delete");
            contextMenuStrip.Items.AddRange(new[] { editMenuItem, deleteMenuItem });
            card.ContextMenuStrip = contextMenuStrip;
            editMenuItem.Click += EditMenuItem_Click;
            deleteMenuItem.Click += DeleteMenuItem_Click;

            var photo = new PictureBox();
            photo.Location = new Point(0, 0);
            photo.Size = new Size(200, 200);
            photo.SizeMode = PictureBoxSizeMode.StretchImage;
            card.Controls.Add(photo);

            var fields = this.ToString().Split("; ");
            for (int i = 0; i < fields.Length; i++)
            {
                var description = new Label();
                description.AutoSize = true;
                description.Font = new Font("Segoe UI", i == 0 ? 14.2F : 12.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
                description.Location = new Point(0, card.Controls[^1].Location.Y + card.Controls[^1].Size.Height);
                description.Text = fields[i];
                card.Controls.Add(description);
            }

            return card;
        }

        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            new EditForm(this).ShowDialog();
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            Program.Cars.Delete(this);
        }

        public Car DeepCopy()
        {
            Car copy = (Car)this.MemberwiseClone(); 

            copy.Engine = new Engine(this.Engine.Type);

            return copy;
        }
    }
}
