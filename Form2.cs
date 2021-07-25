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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задача: получить заданное число за наименльшее число попыток. \n +1 - увеличить число на 1." +
                "\n х2 - увеличить число в 2 раза. \n Сброс - вернуться к началу.", "Правила", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
