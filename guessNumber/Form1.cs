using System;
using System.Windows.Forms;

namespace guessNumber
{
    public partial class Form1 : Form
    {
        randNumber rnum;
        int max;
        Form2 f2;
        public Form1()
        {
            max = 100;
            rnum = new randNumber(max);
            InitializeComponent();
            btnCheck.Text = "Проверить";
            this.Text = "Угадай число";
            lblStepCount.Text = "0";
            lblEnterTheNumber.Text = $"Введите число от 0 до {max}:";
            lblStepText.Text = "Счёт ходов:";
            MessageBox.Show("Вводите в поле число пока не угадаете. Нажимайте кнопку \"Проверить\" " +
                "чтобы узнать результат попытки. ", "Правила");
            tboxUserAnswer.Visible = false;
            f2 = new Form2();
            f2.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool check;
            MessageBox.Show(rnum.CheckValue(out check, f2.userAnswer));
            if (check)
            {
                rnum.Reset(max);
                MessageBox.Show($"Игра началась заново.\nВведите число от 0 до {max}:");
            }
            Update();
        }

        void Update()
        {
            lblStepCount.Text = rnum.Steps.ToString();
            this.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tboxUserAnswer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
