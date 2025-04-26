using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frm_calculator : Form
    {
        
        public frm_calculator()
        {
            InitializeComponent();
        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt_sothunhat.Text);
            int b = int.Parse(txt_sothuhai.Text);
            Calculation calculation = new Calculation(a, b);
            txt_ketqua.Text = calculation.Execute("add").ToString();
        }

        private void btn_tru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt_sothunhat.Text);
            int b = int.Parse(txt_sothuhai.Text);
            Calculation calculation = new Calculation(a, b);
            txt_ketqua.Text = calculation.Execute("subtract").ToString();
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt_sothunhat.Text);
            int b = int.Parse(txt_sothuhai.Text);
            Calculation calculation = new Calculation(a, b);
            txt_ketqua.Text = calculation.Execute("multiply").ToString();
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt_sothunhat.Text);
            int b = int.Parse(txt_sothuhai.Text);
            Calculation calculation = new Calculation(a, b);
            txt_ketqua.Text = calculation.Execute("divide").ToString();
        }
    }
}
