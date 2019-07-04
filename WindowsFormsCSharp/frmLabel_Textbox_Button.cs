using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCSharp
{
    public partial class frmLabel_Textbox_Button : Form
    {
        public frmLabel_Textbox_Button()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtTen.Text;
        }

        private void BtnHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text + " " + txtTen.Text;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát",
                "Thoát chương trình",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);

            if (ret == DialogResult.Yes)
                Close();
        }
    }
}
