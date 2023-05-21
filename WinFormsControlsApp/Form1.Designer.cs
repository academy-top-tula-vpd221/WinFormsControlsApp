namespace WinFormsControlsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            startButton = new Button();
            textLabel = new Label();
            textBox1 = new TextBox();
            cityTextBox = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            tabloLabel = new Label();
            passwordErrorLabel = new Label();
            maskedTextBox1 = new MaskedTextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.BackColor = SystemColors.ActiveCaption;
            startButton.BackgroundImageLayout = ImageLayout.Stretch;
            startButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            startButton.ForeColor = SystemColors.Window;
            startButton.Image = (Image)resources.GetObject("startButton.Image");
            startButton.Location = new Point(575, 329);
            startButton.Name = "startButton";
            startButton.Size = new Size(213, 109);
            startButton.TabIndex = 2;
            startButton.Text = "&Нажми меня";
            startButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.BackColor = SystemColors.ControlLightLight;
            textLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textLabel.ForeColor = Color.OrangeRed;
            textLabel.Location = new Point(32, 9);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(63, 37);
            textLabel.TabIndex = 3;
            textLabel.Text = "City";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(32, 218);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(313, 209);
            textBox1.TabIndex = 4;
            textBox1.Text = "dasfdasfdas";
            textBox1.WordWrap = false;
            // 
            // cityTextBox
            // 
            cityTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            cityTextBox.Location = new Point(32, 62);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(313, 36);
            cityTextBox.TabIndex = 5;
            cityTextBox.TextChanged += cityTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 110);
            label1.Name = "label1";
            label1.Size = new Size(103, 30);
            label1.TabIndex = 6;
            label1.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(32, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(313, 36);
            textBox2.TabIndex = 7;
            textBox2.UseSystemPasswordChar = true;
            textBox2.Leave += textBox2_Leave;
            // 
            // tabloLabel
            // 
            tabloLabel.AutoSize = true;
            tabloLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tabloLabel.Location = new Point(382, 62);
            tabloLabel.Name = "tabloLabel";
            tabloLabel.Size = new Size(0, 30);
            tabloLabel.TabIndex = 8;
            // 
            // passwordErrorLabel
            // 
            passwordErrorLabel.AutoSize = true;
            passwordErrorLabel.ForeColor = Color.Red;
            passwordErrorLabel.Location = new Point(351, 143);
            passwordErrorLabel.Name = "passwordErrorLabel";
            passwordErrorLabel.Size = new Size(0, 15);
            passwordErrorLabel.TabIndex = 9;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(397, 12);
            maskedTextBox1.Mask = "LL-0000.00$";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(248, 36);
            maskedTextBox1.TabIndex = 10;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(411, 79);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(135, 34);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(411, 119);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(135, 34);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.Click += checkBox2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(411, 206);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(411, 231);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(411, 256);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 15;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Location = new Point(554, 206);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(20, 47);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(94, 19);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "radioButton5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(20, 22);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(94, 19);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(passwordErrorLabel);
            Controls.Add(tabloLabel);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(cityTextBox);
            Controls.Add(textBox1);
            Controls.Add(textLabel);
            Controls.Add(startButton);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Label textLabel;
        private TextBox textBox1;
        private TextBox cityTextBox;
        private Label label1;
        private TextBox textBox2;
        private Label tabloLabel;
        private Label passwordErrorLabel;
        private MaskedTextBox maskedTextBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox1;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
    }
}