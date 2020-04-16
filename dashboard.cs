using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_project
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserManagement userm = new UserManagement();
            userm.Show();
            this.Visible = false;
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void butt1_Click(object sender, EventArgs e)
        {
            Products pro = new Products();
            pro.Show();
            this.Visible = false;
        }
    }
}
