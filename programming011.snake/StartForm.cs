using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programming011.snake
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Form f = new frmMain();

            f.Show();
            this.Visible = false;
            f.FormClosed += MainFormClosed;
        }

        private void MainFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
