using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ClickMe_Click(object sender, EventArgs e)
        {
            if (btn_ClickMe.Text=="按我一下")
            btn_ClickMe.Text="我已被點擊了";
            else if (btn_ClickMe.Text=="我已被點擊了")
                btn_ClickMe.Text="按我一下";
        }

        private void btn_ChangeLabel_Click(object sender, EventArgs e)
        {
            lab_ChangLabel.Text="按鈕被按過了";
        }

        private void btn_Counter_Click(object sender, EventArgs e)
        {
            String count = lab_Counter.Text;
            int sum=Int32.Parse(count)+1;
            lab_Counter.Text=sum.ToString();
        }

        private void btnBigger_Click(object sender, EventArgs e)
        {
            new FormBtnBigger().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str=textBox1.Text;
            label2.Text=str;
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            new FormCalculator().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           String count = label3.Text;
        int sum = Int32.Parse(count)+1;
            label3.Text=sum.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String count = label3.Text;
            int sum = Int32.Parse(count)+1;
            label3.Text=sum.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
           String count = label3.Text;
        int sum = Int32.Parse(count)-1;
        label3.Text=sum.ToString();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            new FormTemp() .Show();
        }
    }
}
