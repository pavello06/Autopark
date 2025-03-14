namespace Autopark
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            logoPanel = new Panel();
            titleLabel = new Label();
            iconPictureBox = new PictureBox();
            fieldsFlowLayoutPanel = new FlowLayoutPanel();
            editButton = new Button();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox).BeginInit();
            SuspendLayout();
            // 
            // logoPanel
            // 
            logoPanel.Controls.Add(titleLabel);
            logoPanel.Controls.Add(iconPictureBox);
            logoPanel.Dock = DockStyle.Top;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(282, 46);
            logoPanel.TabIndex = 5;
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
            // fieldsFlowLayoutPanel
            // 
            fieldsFlowLayoutPanel.AutoScroll = true;
            fieldsFlowLayoutPanel.Location = new Point(16, 97);
            fieldsFlowLayoutPanel.Name = "fieldsFlowLayoutPanel";
            fieldsFlowLayoutPanel.Size = new Size(250, 201);
            fieldsFlowLayoutPanel.TabIndex = 6;
            // 
            // editButton
            // 
            editButton.Enabled = false;
            editButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editButton.Location = new Point(16, 345);
            editButton.Name = "editButton";
            editButton.Size = new Size(250, 75);
            editButton.TabIndex = 7;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 432);
            Controls.Add(editButton);
            Controls.Add(fieldsFlowLayoutPanel);
            Controls.Add(logoPanel);
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit";
            logoPanel.ResumeLayout(false);
            logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel logoPanel;
        private Label titleLabel;
        private PictureBox iconPictureBox;
        private FlowLayoutPanel fieldsFlowLayoutPanel;
        private Button editButton;
    }
}