using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 실행 ctrl + F5
            // mbox적고 tab키 두번 누르면 아래 코드가 자동으로 나옴 
            MessageBox.Show("안녕하세요");
            MessageBox.Show("goodbye~");
        }
    }
}
