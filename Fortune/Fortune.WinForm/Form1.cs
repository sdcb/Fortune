using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fortune.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uiCalc_Click(object sender, EventArgs e)
        {
            var name = uiName.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("请输入你的名字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                uiScore.Text = Score.GetScoreByName(name).ToString();
            }
        }
    }
}
