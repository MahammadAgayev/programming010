using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programming011.formsui2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPendingToProcess_Click(object sender, EventArgs e)
        {
            //int index = cbxPending.SelectedIndex;

            //var item = cbxPending.Items[index];

            //cbxInProcess.Items.Add(item);
            //cbxPending.Items.Remove(item);

            MoveA2B(cbxPending, cbxInProcess);
        }

        private void btnProcessToPending_Click(object sender, EventArgs e)
        {
            //int index = cbxInProcess.SelectedIndex;

            //var item = cbxInProcess.Items[index];

            //cbxPending.Items.Add(item);
            //cbxInProcess.Items.Remove(item);

            MoveA2B(cbxInProcess, cbxPending);
        }

        private void btnProcessToDone_Click(object sender, EventArgs e)
        {
            //int index = cbxInProcess.SelectedIndex;

            //var item = cbxInProcess.Items[index];

            //cbxDone.Items.Add(item);
            //cbxInProcess.Items.Remove(item);

            MoveA2B(cbxInProcess, cbxDone);
        }

        private void btnDoneToProces_Click(object sender, EventArgs e)
        {
            //int index = cbxDone.SelectedIndex;

            //var item = cbxDone.Items[index];

            //cbxInProcess.Items.Add(item);
            //cbxDone.Items.Remove(item);

            MoveA2B(cbxDone, cbxInProcess);
        }

        private void MoveA2B(ComboBox a, ComboBox b)
        {
            int index = a.SelectedIndex;

            if (index == -1)
            {
                //MessageBox.Show("Please select an item", "Item not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            var item = a.Items[index];

            a.Items.Remove(item);
            b.Items.Add(item);

            a.Text = string.Empty;
            b.Text = string.Empty;
        }

        private void cbxDone_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                MoveA2B(cbxDone, cbxInProcess);
            }
        }

        private void cbxInProcess_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                MoveA2B(cbxInProcess, cbxDone);
            }
            else if(e.KeyCode == Keys.Left)
            {
                MoveA2B(cbxInProcess, cbxPending); ;
            }
        }

        private void cbxPending_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                MoveA2B(cbxPending, cbxInProcess);
            }
        }
    }
}
