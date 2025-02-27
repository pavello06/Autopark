namespace Autopark
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            asidePanel = new Panel();
            actionsPanel = new Panel();
            logoPanel = new Panel();
            titleLabel = new Label();
            iconPictureBox = new PictureBox();
            autoparkFlowLayoutPanel = new FlowLayoutPanel();
            asidePanel.SuspendLayout();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox).BeginInit();
            SuspendLayout();
            // 
            // asidePanel
            // 
            asidePanel.Controls.Add(actionsPanel);
            asidePanel.Controls.Add(logoPanel);
            asidePanel.Dock = DockStyle.Left;
            asidePanel.Location = new Point(0, 0);
            asidePanel.Name = "asidePanel";
            asidePanel.Size = new Size(226, 450);
            asidePanel.TabIndex = 0;
            // 
            // actionsPanel
            // 
            actionsPanel.Dock = DockStyle.Bottom;
            actionsPanel.Location = new Point(0, 57);
            actionsPanel.Name = "actionsPanel";
            actionsPanel.Size = new Size(226, 393);
            actionsPanel.TabIndex = 3;
            // 
            // logoPanel
            // 
            logoPanel.Controls.Add(titleLabel);
            logoPanel.Controls.Add(iconPictureBox);
            logoPanel.Dock = DockStyle.Top;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(226, 51);
            logoPanel.TabIndex = 2;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Dock = DockStyle.Right;
            titleLabel.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleLabel.Location = new Point(95, 0);
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
            iconPictureBox.Size = new Size(89, 51);
            iconPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            iconPictureBox.TabIndex = 2;
            iconPictureBox.TabStop = false;
            // 
            // autoparkFlowLayoutPanel
            // 
            autoparkFlowLayoutPanel.Dock = DockStyle.Right;
            autoparkFlowLayoutPanel.Location = new Point(232, 0);
            autoparkFlowLayoutPanel.Name = "autoparkFlowLayoutPanel";
            autoparkFlowLayoutPanel.Size = new Size(568, 450);
            autoparkFlowLayoutPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(autoparkFlowLayoutPanel);
            Controls.Add(asidePanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YPark";
            asidePanel.ResumeLayout(false);
            logoPanel.ResumeLayout(false);
            logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel asidePanel;
        private Panel logoPanel;
        private Label titleLabel;
        private PictureBox iconPictureBox;
        private Panel actionsPanel;
        private FlowLayoutPanel autoparkFlowLayoutPanel;
    }
}
