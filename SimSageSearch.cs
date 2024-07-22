using System.Diagnostics;
using Microsoft.Win32;

namespace SimSageSearch
{
    public partial class SimSageSearch : Form
    {
        private readonly string strKeyPath = @"HKEY_CURRENT_USER\SimSageSearch";
        private readonly string strKeyName = "URL";

        private bool blSubWindowActive = false;
        public SimSageSearch()
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

            string strSimSageURL = GetRegistryEntryURL();

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

        private void SearchForm_Deactivate(object sender, EventArgs e)
        {
            // If the messagebox is active just leave
            if (blSubWindowActive) return;

            this.WindowState = FormWindowState.Minimized;
        }

        #region Context Menu Event Handling
        private void contextMenuSettings_Closing(object sender, EventArgs e)
        {
            SetRegistryEntry(toolStripTextURL.Text);
            blSubWindowActive = false;
        }

        private void contextMenuSettings_Opening(object sender, EventArgs e)
        {
            toolStripTextURL.Text = GetRegistryEntryURL();
            blSubWindowActive = true;
        }
        private void toolStripMenuExit_Click(object sender, EventArgs e)
        {
            blSubWindowActive = true;
            if (MessageBox.Show("Are you sure you want to close SimSage Search?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Close();
            blSubWindowActive = false;
        }
        #endregion

        #region Registry Setting and Getting
        private void SetRegistryEntry(string strURL)
        {
            Registry.SetValue(strKeyPath, strKeyName, strURL);
        }

        private string GetRegistryEntryURL()
        {
            string? strResult = Registry.GetValue(strKeyPath, strKeyName, "demo.simsage.ai")?.ToString() ?? "demo.simsage.ai";

            return (strResult);
        }
        #endregion

    }
}
