using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace WFLaba2
{
    public partial class Form1 : Form
    {
        private Button[] arrayOfButtons = new Button[16];
        private Random random = new Random();
        private List<int> mynums = new List<int>();
        private int i = 1;
        private int randomValue;
        private Button AddButton;
        private ComboBox comboBox1;
        private TabPage tbTask2;
        private TextBox txtBox;
        private TabControl tbControl;
        private TabPage tbTask1;
        private Button RemoveButton;
        private TextBox txtBoxResult;
        private Button button1;

        public Form1()
        {
            this.Init();
            int num1 = 1;
            foreach (Button btn in this.arrayOfButtons)
                this.mynums.Add(num1++);
            int num2 = 0;
            int num3 = 0;
            for (int index1 = 1; index1 < this.arrayOfButtons.Length + 1; ++index1)
            {
                this.button1 = new Button();
                Button button1 = this.button1;
                int num4 = num3;
                Size size = this.button1.Size;
                int width = size.Width;
                int x = num4 * width + 60;
                int num5 = (index1 - 1) % 4;
                size = this.button1.Size;
                int height = size.Height;
                int y = num5 * height + 30;
                Point pnt = new Point(x, y);
                button1.Location = pnt;
                int index2 = this.random.Next(this.mynums.Count - 1);              
                this.button1.Click += new EventHandler(this.btnArray_Click);
                 this.button1.Name = this.mynums[index2].ToString();
                this.button1.Size = new Size(new Point(40, 20));
                this.button1.Text = this.mynums[index2].ToString();
                this.mynums.RemoveAt(index2);
                num2 = index2 + 1;
                this.arrayOfButtons[index1 - 1] = this.button1;
                this.tbTask2.Controls.Add((Control)this.arrayOfButtons[index1 - 1]);
                if (index1 % 4 == 0)
                    ++num3;
            }
            int num6 = 1;
            foreach (Button btn in this.arrayOfButtons)
                this.mynums.Add(num6++);
        }
        private void btn_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name == this.AddButton.Name)
            {
                if (!(this.txtBox.Text != ""))
                    return;
                this.comboBox1.Items.Add((object)this.txtBox.Text);
                this.txtBox.Text = "";
            }
            else
            {
                if ((uint)this.comboBox1.Items.Count <= 0U)
                    return;
                this.comboBox1.Items.RemoveAt(this.comboBox1.Items.Count - 1);
            }
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name == this.i.ToString())
            {
                this.txtBoxResult.Text = "";
                (sender as Button).Visible = false;
                this.mynums.RemoveAt(this.mynums.IndexOf(this.i));
                foreach (Button btn in this.arrayOfButtons)
                {
                    if (btn.Visible)
                    {
                        this.randomValue = this.random.Next(this.mynums.Count);
                        Button button1 = btn;
                        int number = this.mynums[this.randomValue];
                        string str1 = number.ToString();
                        button1.Name = str1;
                        Button button2 = btn;
                        number = this.mynums[this.randomValue];
                        string str2 = number.ToString();
                        button2.Text = str2;
                        this.mynums.RemoveAt(this.randomValue);
                    }
                }
                for (int index = this.i + 1; index < this.arrayOfButtons.Length + 1; ++index)
                    this.mynums.Add(index);
                ++this.i;
            }
            else if (this.i != 1)
                this.Clearmynums();
            if (this.i != 17)
                return;
            this.txtBoxResult.TextAlign = HorizontalAlignment.Center;
            this.txtBoxResult.Text = "хорошая работа";
            this.Clearmynums();
        }

        private void Clearmynums()
        {
            this.mynums.Clear();
            this.i = 1;
            for (int i = this.i; i < this.arrayOfButtons.Length + 1; ++i)
                this.mynums.Add(i);
            foreach (Button btn in this.arrayOfButtons)
            {
                if (!btn.Visible)
                    btn.Visible = true;
                this.randomValue = this.random.Next(this.mynums.Count - 1);
                Button button1 = btn;
                int number = this.mynums[this.randomValue];
                string str1 = number.ToString();
                button1.Name = str1;
                Button button2 = btn;
                number = this.mynums[this.randomValue];
                string str2 = number.ToString();
                button2.Text = str2;
                this.mynums.RemoveAt(this.randomValue);
            }
            for (int i = this.i; i < this.arrayOfButtons.Length + 1; ++i)
                this.mynums.Add(i);
        }
        private void Init()
        {
            this.tbControl = new TabControl();
            this.tbTask1 = new TabPage();
            this.txtBox = new TextBox();
            this.RemoveButton = new Button();
            this.AddButton = new Button();
            this.comboBox1 = new ComboBox();
            this.tbTask2 = new TabPage();
            this.txtBoxResult = new TextBox();
            this.button1 = new Button();
            this.tbControl.SuspendLayout();
            this.tbTask1.SuspendLayout();
            this.tbTask2.SuspendLayout();
            this.SuspendLayout();
            this.tbControl.Controls.Add((Control)this.tbTask1);
            this.tbControl.Controls.Add((Control)this.tbTask2);
            this.tbControl.Location = new Point(12, 12);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new Size(380, 239);
            this.tbControl.TabIndex = 0;
            this.tbTask1.Controls.Add((Control)this.txtBox);
            this.tbTask1.Controls.Add((Control)this.RemoveButton);
            this.tbTask1.Controls.Add((Control)this.AddButton);
            this.tbTask1.Controls.Add((Control)this.comboBox1);
            this.tbTask1.Location = new Point(4, 22);
            this.tbTask1.Name = "tbTask1";
            this.tbTask1.Padding = new Padding(3);
            this.tbTask1.Size = new Size(372, 213);
            this.tbTask1.TabIndex = 0;
            this.tbTask1.Text = "Task 1";
            this.tbTask1.UseVisualStyleBackColor = true;
            this.txtBox.BackColor = Color.White;
            this.txtBox.Location = new Point(6, 9);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new Size(121, 20);
            this.txtBox.TabIndex = 3;
            this.RemoveButton.ForeColor = Color.Green;
            this.RemoveButton.Location = new Point(247, 6);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new Size(75, 23);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new EventHandler(this.btn_Click);
            this.AddButton.ForeColor = Color.Red;
            this.AddButton.Location = new Point(152, 6);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new EventHandler(this.btn_Click);
            this.comboBox1.BackColor = Color.Green;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new Point(6, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.tbTask2.Controls.Add((Control)this.txtBoxResult);
            this.tbTask2.Location = new Point(4, 22);
            this.tbTask2.Name = "tbTask2";
            this.tbTask2.Padding = new Padding(3);
            this.tbTask2.Size = new Size(372, 213);
            this.tbTask2.TabIndex = 1;
            this.tbTask2.Text = "Task 2";
            this.tbTask2.UseVisualStyleBackColor = true;
            this.txtBoxResult.BackColor = Color.White;
            this.txtBoxResult.Location = new Point(119, 174);
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.Size = new Size(147, 20);
            this.txtBoxResult.TabIndex = 0;
            this.button1.Location = new Point(30, 23);
            this.button1.Name = "button1";
            this.button1.Size = new Size(40, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(636, 399);
            this.Controls.Add((Control)this.tbControl);
            this.Name = nameof(Form1);
            this.Text = nameof(Form1);
            this.tbControl.ResumeLayout(false);
            this.tbTask1.ResumeLayout(false);
            this.tbTask1.PerformLayout();
            this.tbTask2.ResumeLayout(false);
            this.tbTask2.PerformLayout();
            this.ResumeLayout(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
