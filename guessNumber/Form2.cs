using System;
using System.Windows.Forms;

namespace guessNumber
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Text = "Введите число";
        }

        public int userAnswer
        {
            get { return int.Parse(tboxAnswer.Text); }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tboxAnswer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
