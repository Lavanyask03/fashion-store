using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FASHION_STORE_MANAGEMENT_SYSTEM
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trends_button_Click(object sender, EventArgs e)
        {
            if (!content_panel.Controls.Contains(TrendsUserControl.Instance))
            {
                content_panel.Controls.Add(TrendsUserControl.Instance);
                TrendsUserControl.Instance.Dock = DockStyle.Fill;
                TrendsUserControl.Instance.BringToFront();
            }
            else
            {
                TrendsUserControl.Instance.BringToFront();
            }
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            if(!content_panel.Controls.Contains(HomeUserControl.Instance))
            {
                content_panel.Controls.Add(HomeUserControl.Instance);
                HomeUserControl.Instance.Dock = DockStyle.Fill;
                HomeUserControl.Instance.BringToFront();
            }
            else
            {
                HomeUserControl.Instance.BringToFront();
            }
        }

        private void men_button_Click(object sender, EventArgs e)
        {
            if (!content_panel.Controls.Contains(MenUserControl.Instance))
            {
                content_panel.Controls.Add(MenUserControl.Instance);
                MenUserControl.Instance.Dock = DockStyle.Fill;
                MenUserControl.Instance.BringToFront();
            }
            else
            {
                MenUserControl.Instance.BringToFront();
            }
        }

        private void women_button_Click(object sender, EventArgs e)
        {
            if (!content_panel.Controls.Contains(WomenUserControl.Instance))
            {
                content_panel.Controls.Add(WomenUserControl.Instance);
                WomenUserControl.Instance.Dock = DockStyle.Fill;
                WomenUserControl.Instance.BringToFront();
            }
            else
            {
                WomenUserControl.Instance.BringToFront();
            }
        }

        private void accessories_button_Click(object sender, EventArgs e)
        {
            if (!content_panel.Controls.Contains(AccessoriesUserControl.Instance))
            {
                content_panel.Controls.Add(AccessoriesUserControl.Instance);
                AccessoriesUserControl.Instance.Dock = DockStyle.Fill;
                AccessoriesUserControl.Instance.BringToFront();
            }
            else
            {
                AccessoriesUserControl.Instance.BringToFront();
            }
        }

        private void feedback_button_Click(object sender, EventArgs e)
        {
            if (!content_panel.Controls.Contains(FeedbackUserControl.Instance))
            {
                content_panel.Controls.Add(FeedbackUserControl.Instance);
                FeedbackUserControl.Instance.Dock = DockStyle.Fill;
                FeedbackUserControl.Instance.BringToFront();
            }
            else
            {
                FeedbackUserControl.Instance.BringToFront();
            }
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            if (!content_panel.Controls.Contains(LogoutUserControl.Instance))
            {
                content_panel.Controls.Add(LogoutUserControl.Instance);
                LogoutUserControl.Instance.Dock = DockStyle.Fill;
                LogoutUserControl.Instance.BringToFront();
            }
            else
            {
                LogoutUserControl.Instance.BringToFront();
            }
        }

        private void content_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
