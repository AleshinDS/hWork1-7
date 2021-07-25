using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hWor1_7
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            lblTask.Text = Convert.ToString(rnd.Next(1, 1024));
            this.Text = "Удвоитель";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            lblCount.Text = (int.Parse(lblCount.Text) + 1).ToString();
            if (lblTask.Text == lblNumber.Text)
            {
                MessageBox.Show($"Вы достигли цели за {lblCount.Text} ходов!", "Поздравляем!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            lblCount.Text = (int.Parse(lblCount.Text) + 1).ToString();
            if (lblTask.Text == lblNumber.Text)
            {
                MessageBox.Show($"Вы достигли цели за {lblCount.Text} ходов!", "Поздравляем!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            lblCount.Text = (int.Parse(lblCount.Text) - int.Parse(lblCount.Text)).ToString();
        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblCountInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblTask_Click(object sender, EventArgs e)
        {

        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }

        private void lblTaskInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
