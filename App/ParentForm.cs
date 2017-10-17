using System;
using System.Windows.Forms;

namespace App
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void WinAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinApp form = new WinApp
            {
                MdiParent = this
            };

            form.Show();
        }

        private void UserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfo form = new UserInfo
            {
                MdiParent = this
            };

            form.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }
    }
}
