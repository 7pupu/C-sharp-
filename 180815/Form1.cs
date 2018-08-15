using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3 {
    public partial class Form1 : Form {
        Graphics fg;

        public Form1() {
            InitializeComponent();
            fg = this.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e) {
            fg.Clear(this.BackColor);//用背景色蓋過畫布=清空塗鴉
            fg.DrawLine(
                new Pen(Color.Red, 10),
                new Point(100, 100),
                new Point(300, 300)
                );
        }

        private void button2_Click(object sender, EventArgs e) {
            fg.Clear(this.BackColor);//用背景色蓋過畫布=清空塗鴉
            Pen pp = new Pen(Color.Red, 10);
            pp.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            pp.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pp.EndCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            fg.DrawLine(
                pp,
                new Point(100, 100),
                new Point(300, 300)
                );

            Pen pp2 = new Pen(Color.Blue, 5);
            fg.DrawLines(pp2,
                new Point[] {
                    new Point(100, 100),
                    new Point(150, 100),
                    new Point(150, 150),
                    new Point(200, 150),
                    new Point(200, 200)
                });
        }

        private void button3_Click(object sender, EventArgs e) {
            fg.Clear(this.BackColor);//用背景色蓋過畫布=清空塗鴉
            Pen pp = new Pen(Color.Red, 10);
            fg.DrawRectangle(pp, 100, 100, 200, 300);
        }

        private void button4_Click(object sender, EventArgs e) {
            fg.Clear(this.BackColor);
            Random rr = new Random();
            for (int i = 0; i < 3; i++) {
                Pen pp = new Pen(Color.FromArgb(rr.Next(256), rr.Next(256), rr.Next(256)), 10);//Color.Red
                fg.DrawRectangle(pp, 100 + i * 50, 100 + i * 50, 200, 300);
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            fg.Clear(this.BackColor);
            Brush bb = new SolidBrush(Color.Pink);
            fg.FillRectangle(bb, new Rectangle(new Point(100, 100), new Size(200, 100)));
        }

        private void button6_Click(object sender, EventArgs e) {
            fg.Clear(this.BackColor);
            Random rr = new Random();
            for (int i = 0; i < 3; i++) {
                Brush bb = new SolidBrush(Color.FromArgb(rr.Next(256), rr.Next(256), rr.Next(256)));
                //fg.FillRectangles(bb, new Rectangle[] {
                fg.FillRectangle(bb, new Rectangle(new Point(100 + i * 50, 100 + i * 50), new Size(200, 100)));
            }
        }

        private void button7_Click(object sender, EventArgs e) {
            fg.Clear(this.BackColor);
            Random rr = new Random();
            Brush bb = new SolidBrush(Color.FromArgb(rr.Next(256), rr.Next(256), rr.Next(256)));
            fg.FillEllipse(bb, new Rectangle(new Point(100, 100), new Size(200, 100)));
        }

        private void button8_Click(object sender, EventArgs e) {
            fg.Clear(this.BackColor);
            //
            Dictionary<String, int> vv = new Dictionary<String, int>();
            vv.Add("aaa", 500);
            vv.Add("bbb", 700);
            vv.Add("ccc", 1200);
            vv.Add("ddd", 600);

            int total = 0;
            String result = "";
            for (int i = 0; i < vv.Count; i++) {
                var item = vv.ElementAt(i);
                var itemKey = item.Key;
                var itemValue = item.Value;
            }
            foreach (KeyValuePair<String, int> aa in vv) {
                total += aa.Value;
                //result += "\r\n" + aa.Value;
            }

            Random rr = new Random();
            Brush bb = null;

            double sweep = 0.0;
            double angle = 0.0;
            foreach (KeyValuePair<String, int> aa in vv) {
                angle = ((double)aa.Value / total) * 360;
                bb = new SolidBrush(Color.FromArgb(rr.Next(256), rr.Next(256), rr.Next(256)));
                fg.FillPie(bb, new Rectangle(new Point(100, 100), new Size(200, 200)), (float)sweep, (float)angle);
                sweep += angle;
            }
        }

        private void button9_Click(object sender, EventArgs e) {
            fg.Clear(this.BackColor);
            String ss = "呵呵呵呵呵呵呵呵呵";
            Font ff = new Font("標楷體", 24, FontStyle.Bold);
            Brush bb = new System.Drawing.Drawing2D.LinearGradientBrush(
                new Point(100, 100),
                new Point(200, 200),
                Color.Red,
                Color.Blue
                );
            fg.FillRectangle(bb, new Rectangle(new Point(100, 100), new Size(100, 200)));
            fg.DrawString(ss, ff, bb, new Point(100, 100));
        }

        private void button10_Click(object sender, EventArgs e) {
            fg.Clear(this.BackColor);
            Image ii = Properties.Resources._1534179109016;
            fg.DrawImage(ii, new Point(50, 50));//原圖
            Bitmap bmp = new Bitmap(ii, new Size(640, 360));
            fg.DrawImage(bmp, new Point(50, 50));//改變長寬的圖


        }

        private void button11_Click(object sender, EventArgs e) {
            fg.Clear(this.BackColor);
            Image ii = Properties.Resources._1534179109016;
            //Image ii = Image.FromFile(@"C:\原圖.jpg");
            Bitmap bmp = new Bitmap(ii, new Size(640, 360));
            Graphics sg = Graphics.FromImage(bmp);     //從bmp產生繪圖物件
            //畫圓
            Brush bb = new SolidBrush(Color.Red);
            sg.FillEllipse(bb, 0, 0, 50, 50); 
            //寫字
            string s = "過來讓我抱";
            Font ff = new Font("標楷體", 18, FontStyle.Bold);
            bb = new SolidBrush(Color.Blue);
            sg.DrawString(s, ff, bb, new Point(20, 250));
            //把bmp畫出來
            fg.DrawImage(bmp, new Point(50, 50));
            //bmp.Save(@"C:\圖片存檔.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void button12_Click(object sender, EventArgs e) {
            fg.Clear(this.BackColor);
            //
            Image ii = Properties.Resources._1534179109016;
            int block_w = 640;
            int block_h = 360;
            Bitmap bmp = new Bitmap(ii, new Size(block_w, block_h));

            int block_w2 = block_w/2;
            int block_h2 = block_h/2;

            Random rr = new Random();

            //
            Bitmap block_bmp;
            Label L1;
            Graphics gs;
            String ss;
            //0

            //
            /*
                                 ss += "\r\n" + c.Name.Substring(0, 6);
                    ss += "移除";
                    if (c.Name.Substring(0, 5) == "block") {


             */
            //
            ss = "";
            List < Control > list_ctrl = new List<Control>();
            foreach (Control c in this.Controls) {
                list_ctrl.Add(c);
            }
            foreach (Control c in list_ctrl) {
                if (c is Label) {
                    ss += "\r\n" + c.Name;
                    c.Dispose();
                    this.Controls.Remove(c);
                    ss += "移除";
                }
            }
            //MessageBox.Show("" + ss);


            //1
            block_bmp = new Bitmap(block_w2, block_h2 );//空的圖片
            gs = Graphics.FromImage(block_bmp);//在空的圖片作畫

            gs.DrawImage(bmp,
                new Rectangle(0, 0, block_w2, block_h2),
                new Rectangle(0, 0, block_w2, block_h2),
                 GraphicsUnit.Pixel);//擷取部分圖片
            //
            L1 = new Label();
            L1.Name = "block1";
            L1.AutoSize = false;
            L1.Image = block_bmp;
            L1.Width = block_bmp.Width;
            L1.Height = block_bmp.Height;
            L1.Location = new Point(rr.Next(200), rr.Next(200));
            L1.MouseDown += ImageLabelMouseDown;
            L1.MouseUp += ImageLabelMouseUp;
            L1.MouseMove += ImageLabelMouseMove;
            this.Controls.Add(L1);

            //2
            block_bmp = new Bitmap(block_w2, block_h2);//空的圖片
            gs = Graphics.FromImage(block_bmp);//在空的圖片作畫

            gs.DrawImage(bmp,
                new Rectangle(0, 0, block_w2, block_h2),
                new Rectangle(block_w2, 0, block_w2, block_h2),
                 GraphicsUnit.Pixel);//擷取部分圖片
            //
            L1 = new Label();
            L1.Name = "block2";
            L1.AutoSize = false;
            L1.Image = block_bmp;
            L1.Width = block_bmp.Width;
            L1.Height = block_bmp.Height;
            L1.Location = new Point(rr.Next(200), rr.Next(200));
            L1.MouseDown += ImageLabelMouseDown;
            L1.MouseUp += ImageLabelMouseUp;
            L1.MouseMove += ImageLabelMouseMove;
            this.Controls.Add(L1);

            //3
            block_bmp = new Bitmap(block_w2, block_h2);//空的圖片
            gs = Graphics.FromImage(block_bmp);//在空的圖片作畫

            gs.DrawImage(bmp,
                new Rectangle(0, 0, block_w2, block_h2),
                new Rectangle(0, block_h2, block_w2, block_h2),
                 GraphicsUnit.Pixel);//擷取部分圖片
            //
            L1 = new Label();
            L1.Name = "block2";
            L1.AutoSize = false;
            L1.Image = block_bmp;
            L1.Width = block_bmp.Width;
            L1.Height = block_bmp.Height;
            L1.Location = new Point(rr.Next(200), rr.Next(200));
            L1.MouseDown += ImageLabelMouseDown;
            L1.MouseUp += ImageLabelMouseUp;
            L1.MouseMove += ImageLabelMouseMove;
            this.Controls.Add(L1);
            //4
            block_bmp = new Bitmap(block_w2, block_h2);//空的圖片
            gs = Graphics.FromImage(block_bmp);//在空的圖片作畫

            gs.DrawImage(bmp,
                new Rectangle(0, 0, block_w2, block_h2),
                new Rectangle(block_w2, block_h2, block_w2, block_h2),
                 GraphicsUnit.Pixel);//擷取部分圖片
            //
            L1 = new Label();
            L1.Name = "block2";
            L1.AutoSize = false;
            L1.Image = block_bmp;
            L1.Width = block_bmp.Width;
            L1.Height = block_bmp.Height;
            L1.Location = new Point(rr.Next(200), rr.Next(200));
            L1.MouseDown += ImageLabelMouseDown;
            L1.MouseUp += ImageLabelMouseUp;
            L1.MouseMove += ImageLabelMouseMove;
            this.Controls.Add(L1);
        }

        int oldX, oldY;
        bool isPress;
        private void ImageLabelMouseDown(object sender, MouseEventArgs e) {
            isPress = true;
            oldX = e.X;
            oldY = e.Y;
            if (e.Button == System.Windows.Forms.MouseButtons.Right) {

            }
        }

        private void ImageLabelMouseMove(object sender, MouseEventArgs e) {
            if (isPress) {
                Label LL = sender as Label;
                LL.Left = e.X + (LL.Left - oldX);
                LL.Top = e.Y + (LL.Top - oldY);
            }
        }


        private void ImageLabelMouseUp(object sender, MouseEventArgs e) {
            isPress = false;
        }
    }
}
