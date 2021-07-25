using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckNum
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            Random rnd = new Random();
            lblTask.Text = Convert.ToString(rnd.Next(0, 100));
            lblCount.Text = "0";

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (int.TryParse(InputNumTextbox.Text, out int number))
            {
                lblCount.Text = (int.Parse(lblCount.Text) + 1).ToString();
                if (InputNumTextbox.Text == lblTask.Text)
                {
                    MessageBox.Show($"Вы угадали число за {lblCount.Text} попыток!", "Вы угадали!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);;
                    
                } else if (int.Parse(InputNumTextbox.Text) > int.Parse(lblTask.Text))
                {
                    MessageBox.Show($"Попробуйте ввести меньшее число", "Вы не угадали",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Попробуйте ввести ,большее число", "Вы не угадали",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ошибка ввода, введите число от 0 до 100", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblMain_Click(object sender, EventArgs e)
        {

        }

        private void InputNumTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTask_Click(object sender, EventArgs e)
        {

        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }
    }
}
