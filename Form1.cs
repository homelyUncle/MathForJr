using System;
using System.Windows.Forms;

namespace Math2._0
{
    public partial class Form1 : Form
    {
        private int minOperand, maxOperand, result, winCount, errCount;


        private void ResTxt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            resultLbl.Text = null;
            if ((e.KeyChar > 47 && e.KeyChar < 58) && num11.Text != null)
            {
                ResTxt2.Focus();
            }
            else if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.KeyChar = (char)0;
                resultLbl.Text = "введите цифру";
                ResTxt1.Focus();
            }
        }

        private void ResTxt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            resultLbl.Text = null;
            if (e.KeyChar == (char)13 && ResTxt1.Text != null)
            {
                if (GetResult(ResTxt1.Text, ResTxt2.Text, ResTxt3.Text, ResTxt4.Text))
                {
                    RightFun();
                }
                else
                {
                    ErrorFun();
                }
            }
            else if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.KeyChar = (char)0;
                resultLbl.Text = "введите цифру";
                ResTxt2.Focus();
            }
            else if (e.KeyChar > 47 && e.KeyChar < 58)
            {
                ResTxt3.Focus();
            }
        }

        private void ResTxt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            resultLbl.Text = null;
            if (e.KeyChar == (char)13 && ResTxt2.Text != null)
            {
                if (GetResult(ResTxt1.Text, ResTxt2.Text, ResTxt3.Text, ResTxt4.Text))
                {
                    RightFun();
                }
                else
                {
                    ErrorFun();
                }
            }
            else if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.KeyChar = (char)0;
                resultLbl.Text = "введите цифру";
                ResTxt3.Focus();
            }
            else if (e.KeyChar > 47 && e.KeyChar < 58)
            {
                ResTxt4.Focus();
            }
        }

        private void ResTxt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            resultLbl.Text = null;
            if (e.KeyChar == (char)13 && ResTxt3.Text != null)
            {
                if (GetResult(ResTxt1.Text, ResTxt2.Text, ResTxt3.Text, ResTxt4.Text))
                {
                    RightFun();
                }
                else
                {
                    ErrorFun();
                }
            }
            else if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.KeyChar = (char)0;
                resultLbl.Text = "введите цифру";
                ResTxt4.Focus();
            }
        }

        public Form1()
        {
            InitializeComponent();
            Start();
            WinsTxtBox.Text = winCount.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сбросить набранные очки?", "Сброс", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                progressBar1.Value = 0;
                winCount = 0;
                WinsTxtBox.Text = winCount.ToString();
                Start();
            }
            else
            {
                ResTxt1.Focus();
            }
        }

        private void ResTxt1_Click(object sender, EventArgs e)
        {
            ResTxt1.Clear();
        }

        private void ResTxt2_Click(object sender, EventArgs e)
        {
            ResTxt2.Clear();
        }

        private void ResTxt3_Click(object sender, EventArgs e)
        {
            ResTxt3.Clear();
        }

        private void ResTxt4_Click(object sender, EventArgs e)
        {
            ResTxt4.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Start();
        }

        //обработка правильных ответов
        private void RightFun()
        {
            resultLbl.Text = "Молодец! Правильно!";
            Button1.Focus();
            winCount++;
            progressBar1.Value += 5;
            WinsTxtBox.Text = winCount.ToString();
            if (progressBar1.Value == 100)
            {
                DialogResult result = MessageBox.Show("Молодец! Задание выполнено!\nПродолжим?", "", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (result == DialogResult.Yes)
                {
                    progressBar1.Value = 0;
                    winCount = 0;
                    errCount = 0;
                    WinsTxtBox.Text = winCount.ToString();
                    Start();
                }
                else Close();
            }
        }

        //обработка неправильных ответов
        private void ErrorFun()
        {
            errCount++;
            ErrorTxtBox.Text = errCount.ToString();
            if (errCount < 6)
            {
                resultLbl.Text = "Неправильно. Попробуй ещё раз";
                ResTxt1.Text = null;
                ResTxt2.Text = null;
                ResTxt3.Text = null;
                ResTxt4.Text = null;
                ResTxt1.Focus();
            }
            else
            {
                errCount = 0;
                ErrorTxtBox.Text = errCount.ToString();
                winCount = 0;
                progressBar1.Value = 0;
                WinsTxtBox.Text = winCount.ToString();
                Start();
            }
        }

        //получение числа из введённых цифр
        private bool GetResult(string a, string b, string c, string d)
        {
            string resultStr = d + c + b + a;
            return Convert.ToInt32(resultStr) == result;
        }


        //генерация примера
        private void Start()
        {
            ResTxt1.Text = null;
            ResTxt2.Text = null;
            ResTxt3.Text = null;
            ResTxt4.Text = null;
            resultLbl.Text = null;
            Random random = new Random();

            
            try
            {
                if (MinOperandTxt.Text != null)
                {
                    minOperand = Int32.Parse(MinOperandTxt.Text);
                    ResTxt1.Focus();
                }
                else
                {
                    MessageBox.Show("Вы не ввели цифры");
                    MinOperandTxt.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Вы ввели не цифры!");
                MinOperandTxt.Text = null;
                MinOperandTxt.Focus();
            }

            try
            {
                if (MaxOperandTxt.Text != null)
                {
                    maxOperand = Int32.Parse(MaxOperandTxt.Text);
                    ResTxt1.Focus();
                }
                else
                {
                    MessageBox.Show("Вы не ввели цифры");
                    MaxOperandTxt.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Вы ввели не цифры!");
                MaxOperandTxt.Text = null;
                MaxOperandTxt.Focus();
            }

            int a = random.Next(minOperand, maxOperand);
            int b = random.Next(minOperand, maxOperand);
            num11.Text = a.ToString();
            num21.Text = b.ToString();

            switch (random.Next(1, 4))
            {
                case 1:
                    singLbl.Text = "+";
                    result = a + b;
                    break;
                case 2:
                    singLbl.Text = "-";
                    result = a - b;
                    if (result < 0)
                    {
                        Start();
                    }
                    break;
                case 3:
                    singLbl.Text = "+";
                    result = a + b;
                    break;
                case 4:
                    singLbl.Text = "-";
                    result = a - b;
                    if (result < 0)
                    {
                        Start();
                    }
                    break;
            }
        }
    }
}
