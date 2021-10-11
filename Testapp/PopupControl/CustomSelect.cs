using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gregg.PopupControl
{
    public partial class CustomSelect : Form
    {
        private int desiredStartLocationX;
        private int desiredStartLocationY;
        public string filterColumn = "";
        public CustomSelect()
        {
            InitializeComponent();
        }

        public CustomSelect(int x, int y)
        {
            desiredStartLocationX = x;
            desiredStartLocationY = y;
            InitializeComponent();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomSelect_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(desiredStartLocationX, desiredStartLocationY);
        }

        private void CustomSelect_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void CustomSelect_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CustomSelect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
