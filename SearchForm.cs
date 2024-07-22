using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();

            WindowState = FormWindowState.Minimized;
            SetWindowPosition();
        }

        private void SetWindowPosition()
        {
            // Set the position of the SimSage search window - this could be dynamic
            int y = Screen.FromPoint(MousePosition).Bounds.Bottom - (Height * 2);
            int x = (Screen.FromPoint(MousePosition).Bounds.Right - Width) / 2;

            Location = new Point(x, y);
        }

        #region Button Handlers
        private void pbButton_Click(object sender, EventArgs e)
        {
            if (tbQueryString.TextLength == 0) return;

            string strSimSageURL = toolStripTextURL.Text ?? "https://demo.simsage.ai";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = $"https://{strSimSageURL}/search?query={tbQueryString.Text}",
                    UseShellExecute = true
                });

                WindowState = FormWindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@$"Error opening the browser: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            contextMenuSettings.Show(MousePosition, ToolStripDropDownDirection.Default);
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            // This really means minimize rather than close
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void SearchForm_Leave(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripMenuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close SimSage Search?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Close();
        }

        private void SearchForm_Deactivate(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
