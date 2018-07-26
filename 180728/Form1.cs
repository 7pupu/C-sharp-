using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            String res = "";
            //animals.animal aa00 = new animals.animal("動物","小黃", "黃");
            //res += aa00.ToString() + "\r\n"; ;
            animals.land.Dog aa01 = new animals.land.Dog("小黃", "黃");
            res += aa01.ToString() + "\r\n"; ;
            animals.land.CAT aa02 = new animals.land.CAT("小花", "花");
            res += aa02.ToString() + "\r\n"; ;

            textBox1.Text = res;
        }


    }
}
