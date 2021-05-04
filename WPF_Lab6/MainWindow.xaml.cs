using System;
using System.Windows.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Threading;

namespace WPFLaba6
{
    /// <summary>
    ///vareraction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer1;
        private Button okButton;
        private Button cancelButton;
        private DispatcherTimer timer2;
        private byte blinkNums = 1;
        private bool show = false;
        private char ch = 'q';
        private bool isClickable = false;
        private double w;
        private double h;

        public MainWindow()
        {
            InitializeComponent();
            this.Init();
            this.h = (double)this.okButton.Height;
            this.w = (double)this.okButton.Width;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.timer1.Interval = TimeSpan.FromSeconds(1);
            if (this.show)
            {
                this.Title = "Press 'OK' button";
                this.show = false;
            }
            else
            {
                this.Title = "";
                this.show = true;
            }
            ++this.blinkNums;
            if (this.blinkNums <= (byte)8)
                return;
            this.timer1.IsEnabled = false;
            this.show = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.show)
            {
                this.Title = "You lose";
                this.show = false;
            }
            else
            {
                this.Title = "";
                this.show = true;
            }
            ++this.blinkNums;
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isClickable)
                return;
            var x1 = e.GetPosition(this).X;
            Point location = GetLocation(this.okButton);
            var num1 = location.X - 20;
            double num2;
            if (x1 > num1)
            {
                var y1 = e.GetPosition(this).Y;
                location = GetLocation(this.okButton);
                var num3 = location.Y - 20;
                if (y1 > num3)
                {
                    var x2 = e.GetPosition(this).X;
                    location = GetLocation(this.okButton);
                    var num4 = location.X + this.okButton.Width / 2;
                    if (x2 < num4)
                    {
                        var y2 = e.GetPosition(this).Y;
                        location = GetLocation(this.okButton);
                        var num5 = location.Y + this.okButton.Height / 2;
                        num2 = y2 < num5 ? 1 : 0;
                        goto label_6;
                    }
                }
            }
            num2 = 0;
        label_6:
            if (num2 != 0)
            {
                Button okButton = this.okButton;
                location = GetLocation(this.okButton);
                var x2 = location.X + 5;
                location = GetLocation(this.okButton);
                var y = location.Y + 5;
                Point point = new Point(x2, y);
                okButton.Margin = SetLocation(point);
                this.ChangeSizeButton(this.okButton);
            }
            var x3 = e.GetPosition(this).X;
            location = GetLocation(this.okButton);
            var num6 = location.X - 15;
            double num7;
            if (x3 > num6)
            {
                var x2 = e.GetPosition(this).X;
                location = GetLocation(this.okButton);
                var num3 = location.X + this.okButton.Width / 2;
                if (x2 < num3)
                {
                    var y1 = e.GetPosition(this).Y;
                    location = GetLocation(this.okButton);
                    var num4 = location.Y + this.okButton.Height / 2;
                    if (y1 > num4)
                    {
                        var y2 = e.GetPosition(this).Y;
                        location = GetLocation(this.okButton);
                        var num5 = location.Y + this.okButton.Height + 20;
                        num7 = y2 < num5 ? 1 : 0;
                        goto label_13;
                    }
                }
            }
            num7 = 0;
        label_13:
            if (num7 != 0)
            {
                Button okButton = this.okButton;
                location = GetLocation(this.okButton);
                var x2 = location.X + 5;
                location = GetLocation(this.okButton);
                var y = location.Y - 5;
                Point point = new Point(x2, y);
                okButton.Margin = SetLocation(point);
                this.ChangeSizeButton(this.okButton);
            }
            var x4 = e.GetPosition(this).X;
            location = GetLocation(this.okButton);
            var num8 = location.X + this.okButton.Width / 2;
            double num9;
            if (x4 > num8)
            {
                var x2 = e.GetPosition(this).X;
                location = GetLocation(this.okButton);
                var num3 = location.X + this.okButton.Width + 20;
                if (x2 < num3)
                {
                    var y1 = e.GetPosition(this).Y;
                    location = GetLocation(this.okButton);
                    var num4 = location.Y + this.okButton.Height / 2;
                    if (y1 > num4)
                    {
                        var y2 = e.GetPosition(this).Y;
                        location = GetLocation(this.okButton);
                        var num5 = location.Y + this.okButton.Height + 20;
                        num9 = y2 < num5 ? 1 : 0;
                        goto label_20;
                    }
                }
            }
            num9 = 0;
        label_20:
            if (num9 != 0)
            {
                Button okButton = this.okButton;
                location = GetLocation(this.okButton);
                var x2 = location.X - 5;
                location = GetLocation(this.okButton);
                var y = location.Y - 5;
                Point point = new Point(x2, y);
                okButton.Margin = SetLocation(point);
                this.ChangeSizeButton(this.okButton);
            }
            var x5 = e.GetPosition(this).X;
            location = GetLocation(this.okButton);
            var num10 = location.X + this.okButton.Width / 2;
            double num11;
            if (x5 > num10)
            {
                var x2 = e.GetPosition(this).X;
                location = GetLocation(this.okButton);
                var num3 = location.X + this.okButton.Width + 20;
                if (x2 < num3)
                {
                    var y1 = e.GetPosition(this).Y;
                    location = GetLocation(this.okButton);
                    var num4 = location.Y + this.okButton.Height / 2;
                    if (y1 < num4)
                    {
                        var y2 = e.GetPosition(this).Y;
                        location = GetLocation(this.okButton);
                        var num5 = location.Y - 20;
                        num11 = y2 > num5 ? 1 : 0;
                        goto label_27;
                    }
                }
            }
            num11 = 0;
        label_27:
            if (num11 != 0)
            {
                Button okButton = this.okButton;
                location = GetLocation(this.okButton);
                var x2 = location.X - 5;
                location = GetLocation(this.okButton);
                var y = location.Y + 5;
                Point point = new Point(x2, y);
                okButton.Margin = SetLocation(point);
                this.ChangeSizeButton(this.okButton);
            }
        }

        private void btnOk_MouseEnter(object sender, EventArgs e)
        {
            if (this.isClickable)
                return;
            Button okButton = this.okButton;
            Point location = GetLocation(this.cancelButton);
            var x = location.X + 150;
            location = GetLocation(this.cancelButton);
            var y = location.Y + 150;
            Point point = new Point(x, y);
            okButton.Margin = SetLocation(point);
        }

        private void btnOk_LocationChanged(object sender, EventArgs e)
        {
            if (GetLocation(this.okButton).X < 5)
                this.okButton.Margin = SetLocation(new Point(GetLocation(this.okButton).X + 175, GetLocation(this.okButton).Y));
            Point location = GetLocation(this.okButton);
            var num1 = location.X + this.okButton.Width + 5;
            var width = this.Width;
            if (num1 > width)
            {
                Button okButton = this.okButton;
                var num2 = this.Width - 100;
                var num3 = okButton.Width * 2;
                var x = num2 - num3;
                location = GetLocation(this.okButton);
                var y = location.Y;
                Point point = new Point(x, y);
                okButton.Margin = SetLocation(point);
            }
            location = GetLocation(this.okButton);
            if (location.Y < 5)
            {
                Button okButton = this.okButton;
                location = GetLocation(this.okButton);
                var x = location.X;
                location = GetLocation(this.okButton);
                var y = location.Y + 100;
                Point point = new Point(x, y);
                okButton.Margin = SetLocation(point);
            }
            location = GetLocation(this.okButton);
            var y1 = location.Y;
            var height1 = okButton.Height;
            var num4 = y1 + height1 + 25;
            var height2 = this.Height;
            if (num4 <= height2)
                return;
            Button btnOk1 = this.okButton;
            location = GetLocation(this.okButton);
            var x1 = location.X;
            var num5 = this.Height - 100;
            var num6 = this.okButton.Height * 2;
            var y2 = num5 - num6;
            Point point1 = new Point(x1, y2);
            btnOk1.Margin = SetLocation(point1);
        }

        private void ChangeSizeButton(Button b)
        {
            this.w -= 0.2;
            this.h -= 0.2;
            b.Width = (int)(this.w - 0.1);
            b.Height = (int)(this.h - 0.1);
            if (b.Width > 0 && b.Height > 0)
                return;
            this.MouseMove -= new MouseEventHandler(this.Window_MouseMove);
            this.timer2.IsEnabled = true;
            this.timer2_Tick((object)null, (EventArgs)null);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var num = (int)MessageBox.Show("Button 'OK' has been clicked");
        }

        private void btnCancel_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.ch == ' ' && (ushort)e.Key == (ushort)65)
                this.ch = 'A';
            if (this.ch == 'A' && (ushort)e.Key == (ushort)68)
                this.ch = 'D';
            if (this.ch != 'D' || (ushort)e.Key != (ushort)88)
                return;
            this.isClickable = true;
        }

        private void btnCancel_KeyUp(object sender, KeyEventArgs e) => this.ch = ' ';

        private void Init()
        {
            this.timer1 = new DispatcherTimer();
            this.okButton = new Button();
            this.cancelButton = new Button();
            this.timer2 = new DispatcherTimer();
            this.timer1.IsEnabled = true;
            this.timer1.Interval = TimeSpan.FromSeconds(3);
            this.timer1.Tick += this.timer_Tick;
            this.okButton.FontFamily = new FontFamily("Regular");
            this.okButton.FontSize = 15.75f;
            this.okButton.FontStyle = FontStyles.Normal;
            this.okButton.Foreground = Brushes.Red;
            this.okButton.Margin = SetLocation(new Point(313, 215));
            this.okButton.Name = "okButton";
            this.okButton.Width = 90;
            this.okButton.Height = 36;
            this.okButton.TabIndex = 1;
            this.okButton.Content = "OK";
            this.okButton.Click += this.btnOk_Click;
            this.okButton.MouseEnter += this.btnOk_MouseEnter;

            this.cancelButton.FontFamily = new FontFamily("Regular");
            this.cancelButton.FontSize = 15.75f;
            this.cancelButton.FontStyle = FontStyles.Normal;
            this.cancelButton.Margin = SetLocation(new Point(313, 257));
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Width = 90;
            this.cancelButton.Height = 36;
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Content = "Cancel";
            this.cancelButton.Click += this.btnCancel_Click;
            this.cancelButton.KeyDown += new KeyEventHandler(this.btnCancel_KeyDown);
            this.cancelButton.KeyUp += new KeyEventHandler(this.btnCancel_KeyUp);
            this.timer2.Interval = TimeSpan.FromSeconds(1);
            this.timer2.Tick += this.timer2_Tick;

            this.mainGrid.Children.Add(okButton);
            this.mainGrid.Children.Add(cancelButton);;
            this.Name = nameof(MainWindow);
            this.Title = nameof(MainWindow);
            this.MouseMove += new MouseEventHandler(this.Window_MouseMove);
        }

        public Point GetLocation(Visual visual)
        {
            var vector = VisualTreeHelper.GetOffset(visual);
            return new Point(vector.X, vector.Y);
        }

        public Thickness SetLocation(Point point)
        {
            return new Thickness(point.X, point.Y, 0, 0);
        }
    }
}
