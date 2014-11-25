using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sample1
{
    public partial class Top_page : Form
    {
        public Top_page()
        {
            InitializeComponent();
        }

        private void Yoyaku_button_Click(object sender, EventArgs e)
        {
            Calendar C = new Calendar();           
            C.Show();
            this.Visible = false;

        }

        private void Syain_button_Click(object sender, EventArgs e)
        {
            Stafflist C = new Stafflist();
            C.Show();
            this.Visible = false;
        }

        private void Kokyaku_button_Click(object sender, EventArgs e)
        {
            Customerlist C = new Customerlist();
            C.Show();
            this.Visible = false;
        }

        private void Room_button_Click(object sender, EventArgs e)
        {
            Calendar C = new Calendar();
            C.Show();
            this.Visible = false;
        }
//not compleate
        private void Top_page_Load(object sender, EventArgs e)
        {

        }
    }
}
