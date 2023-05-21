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
            if (sender is CheckBox check)
            {
                //MessageBox.Show(check.CheckState.ToString());
                //if (check.CheckState == CheckState.Unchecked)
                //{
                //    check.CheckState = CheckState.Indeterminate;
                //    return;
                //}


                //if (check.CheckState == CheckState.Checked)
                //{
                //    check.CheckState = CheckState.Unchecked;
                //    return;
                //}


                //if (check.CheckState == CheckState.Indeterminate)
                //{
                //    check.CheckState = CheckState.Checked;
                //    return;
                //}

                switch (check.CheckState)
                {
                    case CheckState.Unchecked:
                        check.CheckState = CheckState.Indeterminate;
                        return;

                    case CheckState.Indeterminate:
                        check.CheckState = CheckState.Checked;
                        return;

                    case CheckState.Checked:
                        check.CheckState = CheckState.Unchecked;
                        return;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton radioButton)
            {
                if(radioButton.Checked)
                    MessageBox.Show(((RadioButton)sender).Name);
            }
            
        }
    }
}