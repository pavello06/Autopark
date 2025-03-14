namespace Autopark
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            addButton = new Button();
            carTypeComboBox = new ComboBox();
            fieldsFlowLayoutPanel = new FlowLayoutPanel();
            logoPanel = new Panel();
            titleLabel = new Label();
            iconPictureBox = new PictureBox();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox).BeginInit();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Enabled = false;
            addButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addButton.Location = new Point(16, 345);
            addButton.Name = "addButton";
            addButton.Size = new Size(250, 75);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // carTypeComboBox
            // 
            carTypeComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Rare", "Race", "Truck", "Passenger", "Bus" });
            carTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            carTypeComboBox.FormattingEnabled = true;
            carTypeComboBox.ItemHeight = 20;
            carTypeComboBox.Location = new Point(16, 78);
            carTypeComboBox.Name = "carTypeComboBox";
            carTypeComboBox.Size = new Size(250, 28);
            carTypeComboBox.TabIndex = 2;
            carTypeComboBox.SelectedIndexChanged += carTypeComboBox_SelectedIndexChanged;
            // 
            // fieldsFlowLayoutPanel
            // 
            fieldsFlowLayoutPanel.AutoScroll = true;
            fieldsFlowLayoutPanel.Location = new Point(15, 124);
            fieldsFlowLayoutPanel.Name = "fieldsFlowLayoutPanel";
            fieldsFlowLayoutPanel.Size = new Size(250, 201);
            fieldsFlowLayoutPanel.TabIndex = 3;
            // 
            // logoPanel
            // 
            logoPanel.Controls.Add(titleLabel);
            logoPanel.Controls.Add(iconPictureBox);
            logoPanel.Dock = DockStyle.Top;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(282, 46);
            logoPanel.TabIndex = 4;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Dock = DockStyle.Right;
            titleLabel.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleLabel.Location = new Point(151, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(131, 44);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "YPark";
            // 
            // iconPictureBox
            // 
            iconPictureBox.Dock = DockStyle.Left;
            iconPictureBox.Image = (Image)resources.GetObject("iconPictureBox.Image");
            iconPictureBox.Location = new Point(0, 0);
            iconPictureBox.Name = "iconPictureBox";
            iconPictureBox.Size = new Size(89, 46);
            iconPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            iconPictureBox.TabIndex = 2;
            iconPictureBox.TabStop = false;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 432);
            Controls.Add(logoPanel);
            Controls.Add(fieldsFlowLayoutPanel);
            Controls.Add(carTypeComboBox);
            Controls.Add(addButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add";
            logoPanel.ResumeLayout(false);
            logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button addButton;
        private ComboBox carTypeComboBox;
        private FlowLayoutPanel fieldsFlowLayoutPanel;
        private Panel logoPanel;
        private Label titleLabel;
        private PictureBox iconPictureBox;
    }
}