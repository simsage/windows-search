using SimSageSearch.Properties;

namespace WinFormsApp1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            tbQueryString = new TextBox();
            pbButton = new Button();
            bindingSource1 = new BindingSource(components);
            pictureBoxClose = new PictureBox();
            pictureBoxSettings = new PictureBox();
            contextMenuSettings = new ContextMenuStrip(components);
            toolStripTextURL = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuExit = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSettings).BeginInit();
            contextMenuSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbQueryString
            // 
            tbQueryString.BorderStyle = BorderStyle.FixedSingle;
            tbQueryString.Location = new Point(12, 35);
            tbQueryString.Name = "tbQueryString";
            tbQueryString.Size = new Size(232, 23);
            tbQueryString.TabIndex = 0;
            // 
            // pbButton
            // 
            pbButton.DialogResult = DialogResult.OK;
            pbButton.Location = new Point(255, 35);
            pbButton.Name = "pbButton";
            pbButton.Size = new Size(75, 23);
            pbButton.TabIndex = 1;
            pbButton.Text = "Search";
            pbButton.UseVisualStyleBackColor = true;
            pbButton.Click += pbButton_Click;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = Resources.Close;
            pictureBoxClose.Location = new Point(323, 3);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(16, 16);
            pictureBoxClose.TabIndex = 2;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // pictureBoxSettings
            // 
            pictureBoxSettings.Image = Resources.Settings;
            pictureBoxSettings.Location = new Point(301, 3);
            pictureBoxSettings.Name = "pictureBoxSettings";
            pictureBoxSettings.Size = new Size(16, 16);
            pictureBoxSettings.TabIndex = 3;
            pictureBoxSettings.TabStop = false;
            pictureBoxSettings.Click += pictureBoxSettings_Click;
            // 
            // contextMenuSettings
            // 
            contextMenuSettings.Items.AddRange(new ToolStripItem[] { toolStripTextURL, toolStripSeparator1, toolStripMenuExit });
            contextMenuSettings.Name = "contextMenuSettings";
            contextMenuSettings.Size = new Size(161, 57);
            // 
            // toolStripTextURL
            // 
            toolStripTextURL.Name = "toolStripTextURL";
            toolStripTextURL.Size = new Size(100, 23);
            toolStripTextURL.Text = "demo.simsage.ai";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(157, 6);
            // 
            // toolStripMenuExit
            // 
            toolStripMenuExit.Name = "toolStripMenuExit";
            toolStripMenuExit.Size = new Size(160, 22);
            toolStripMenuExit.Text = "&Exit";
            toolStripMenuExit.Click += toolStripMenuExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.Logo;
            pictureBox1.Location = new Point(14, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 25);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AcceptButton = pbButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 67);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxSettings);
            Controls.Add(pictureBoxClose);
            Controls.Add(pbButton);
            Controls.Add(tbQueryString);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Deactivate += Form1_Deactivate;
            Leave += Form1_Leave;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSettings).EndInit();
            contextMenuSettings.ResumeLayout(false);
            contextMenuSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbQueryString;
        private Button pbButton;
        private BindingSource bindingSource1;
        private PictureBox pictureBoxClose;
        private PictureBox pictureBoxSettings;
        private ContextMenuStrip contextMenuSettings;
        private ToolStripTextBox toolStripTextURL;
        private PictureBox pictureBox1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuExit;
    }
}
