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
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            contentPanel = new Panel();
            autoparkFlowLayoutPanel = new FlowLayoutPanel();
            asidePanel = new Panel();
            actionsPanel = new Panel();
            redoButton = new Button();
            undoButton = new Button();
            addButton = new Button();
            logoPanel = new Panel();
            titleLabel = new Label();
            iconPictureBox = new PictureBox();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            menuStrip.SuspendLayout();
            contentPanel.SuspendLayout();
            asidePanel.SuspendLayout();
            actionsPanel.SuspendLayout();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(883, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(181, 26);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(181, 26);
            saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(178, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(181, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(autoparkFlowLayoutPanel);
            contentPanel.Controls.Add(asidePanel);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 28);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(883, 422);
            contentPanel.TabIndex = 1;
            // 
            // autoparkFlowLayoutPanel
            // 
            autoparkFlowLayoutPanel.AutoScroll = true;
            autoparkFlowLayoutPanel.Dock = DockStyle.Fill;
            autoparkFlowLayoutPanel.Location = new Point(226, 0);
            autoparkFlowLayoutPanel.Name = "autoparkFlowLayoutPanel";
            autoparkFlowLayoutPanel.Size = new Size(657, 422);
            autoparkFlowLayoutPanel.TabIndex = 3;
            autoparkFlowLayoutPanel.TabStop = true;
            // 
            // asidePanel
            // 
            asidePanel.Controls.Add(actionsPanel);
            asidePanel.Controls.Add(logoPanel);
            asidePanel.Dock = DockStyle.Left;
            asidePanel.Location = new Point(0, 0);
            asidePanel.Name = "asidePanel";
            asidePanel.Size = new Size(226, 422);
            asidePanel.TabIndex = 2;
            // 
            // actionsPanel
            // 
            actionsPanel.Controls.Add(redoButton);
            actionsPanel.Controls.Add(undoButton);
            actionsPanel.Controls.Add(addButton);
            actionsPanel.Dock = DockStyle.Fill;
            actionsPanel.Location = new Point(0, 51);
            actionsPanel.Name = "actionsPanel";
            actionsPanel.Size = new Size(226, 371);
            actionsPanel.TabIndex = 3;
            // 
            // redoButton
            // 
            redoButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            redoButton.Location = new Point(3, 121);
            redoButton.Name = "redoButton";
            redoButton.Size = new Size(220, 53);
            redoButton.TabIndex = 2;
            redoButton.Text = "Redo";
            redoButton.UseVisualStyleBackColor = true;
            // 
            // undoButton
            // 
            undoButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            undoButton.Location = new Point(3, 62);
            undoButton.Name = "undoButton";
            undoButton.Size = new Size(220, 53);
            undoButton.TabIndex = 1;
            undoButton.Text = "Undo";
            undoButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addButton.Location = new Point(3, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(220, 53);
            addButton.TabIndex = 0;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
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
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 450);
            Controls.Add(contentPanel);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YPark";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            contentPanel.ResumeLayout(false);
            asidePanel.ResumeLayout(false);
            actionsPanel.ResumeLayout(false);
            logoPanel.ResumeLayout(false);
            logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel contentPanel;
        private FlowLayoutPanel autoparkFlowLayoutPanel;
        private Panel asidePanel;
        private Panel actionsPanel;
        private Button redoButton;
        private Button undoButton;
        private Button addButton;
        private Panel logoPanel;
        private Label titleLabel;
        private PictureBox iconPictureBox;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}
