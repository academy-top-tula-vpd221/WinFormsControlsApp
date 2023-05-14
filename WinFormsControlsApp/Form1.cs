namespace WinFormsControlsApp
{
    public partial class Form1 : Form
    {
        AutoCompleteStringCollection cities = new AutoCompleteStringCollection()
        {
            "Москва",
            "Новосибирск",
            "Новокузнецк",
            "Тула",
            "Воронеж",
            "Туапсе",
            "Вологда",
        };


        public Form1()
        {
            InitializeComponent();
            cityTextBox.AutoCompleteCustomSource = cities;
            cityTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cityTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            MessageBox.Show("Hot key!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Отправлено");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Отменено");
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            string msg = "";
            msg += $"[{e.X},{e.Y} btn: {e.Button}, clicks: {e.Clicks}";
            MessageBox.Show(msg);
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox txtBox)
            {
                tabloLabel.Text = txtBox.Text;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox txtBoxPassword)
            {
                if ((txtBoxPassword.Text.Trim().Length < 5))
                {
                    passwordErrorLabel.Text = "Длина пароля должна быть больше 5 символов";
                    txtBoxPassword.BackColor = Color.LightPink;
                    txtBoxPassword.Focus();
                }
                else
                {
                    passwordErrorLabel.Text = "";
                    txtBoxPassword.BackColor = Color.White;
                }


            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is CheckBox check)
            {
                switch(check.CheckState)
                {
                    case CheckState.Unchecked:
                        check.Checked = false;
                        check.CheckState = CheckState.Indeterminate;
                        break;
                    case CheckState.Checked:
                        check.Checked = false;
                        check.CheckState = CheckState.Unchecked;
                        break;
                    
                    case CheckState.Indeterminate:
                        check.Checked = true;
                        check.CheckState = CheckState.Checked;
                        break;
                }
            }
        }
    }
}