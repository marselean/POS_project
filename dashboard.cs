﻿using System;
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

        private void button5_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            inv.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vapeshop buy = new vapeshop();
            buy.Show();
            this.Visible = false;
        }
    }
}
