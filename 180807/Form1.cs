using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3_180807 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void _changed(object sender, EventArgs e) {
            RadioButton rb = (RadioButton)sender;
            Font old_font = textBox1.Font;
            //textBox1.Text = rb.Text.ToString();
            float fontsize = float.Parse(rb.Text.ToString());
            Font new_font = new Font(old_font.FontFamily, fontsize, old_font.Style);
            textBox1.Font = new_font;

        }

        private void _changed02(object sender, EventArgs e) {
            RadioButton rb = (RadioButton)sender;
            Font old_font = textBox1.Font;
            //textBox1.Text = rb.Text.ToString();
            switch (rb.Text.ToString()) {
                case "黑色":
                    textBox1.ForeColor = Color.Black;
                    break;
                case "紅色":
                    textBox1.ForeColor = Color.Red;
                    break;
                case "綠色":
                    textBox1.ForeColor = Color.Green;
                    break;
                case "藍色":
                    textBox1.ForeColor = Color.Blue;
                    break;
            }
            //Font new_font = new Font(old_font.FontFamily, old_font.Size);
            //textBox1.Font = new_font;

        }

        private void _changed03(object sender, EventArgs e) {
            /*
            FontStyle.Bold
                FontStyle.Italic
                FontStyle.Underline
                FontStyle.Strikeout
             */
            FontStyle fs = FontStyle.Regular;
            CheckBox rb = (CheckBox)sender;
            Font old_font = textBox1.Font;
            Font new_font = null;


            switch (rb.Text) {
                case "粗體":
                    fs = FontStyle.Bold;
                    break;
                case "斜體":
                    fs = FontStyle.Italic;
                    break;
                case "底線":
                    fs = FontStyle.Underline;
                    break;
                case "刪除線":
                    fs = FontStyle.Strikeout;
                    break;

            }

            if (rb.Checked) {
                new_font = new Font(old_font.FontFamily, old_font.Size, old_font.Style | fs);
            } else {
                new_font = new Font(old_font.FontFamily, old_font.Size, old_font.Style ^ fs);
            }
            textBox1.Font = new_font;
            //textBox1.Font = new_font;

        }
    }
}
