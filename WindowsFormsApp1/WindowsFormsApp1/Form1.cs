using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPic1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd=new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
             picbox1.ImageLocation = ofd.FileName;
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName);
                picbox2.Image = image;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            picbox3.ImageLocation = "data:image/png;base64,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";
        }
    }
}
