using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
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
    public partial class LoginForm : Form
    {        
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("User");
        static IMongoCollection<Employee> collection = db.GetCollection<Employee>("employees");

        public void ReadAllDocuments()
        {
            List<Employee> list = collection.AsQueryable().ToList<Employee>();
        }

        public LoginForm()
        {
            InitializeComponent();
            ReadAllDocuments();
        }


        private void buttexit_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void buttlogin_Click(object sender, EventArgs e)
        {
            var filter = Builders<Employee>.Filter.Eq("Username", txtuser.Text) & Builders<Employee>.Filter.Eq("Password", txtpass.Text);
            var check = collection.Find(filter).FirstOrDefault();

            if (check != null)
            {
                dashboard board = new dashboard();
                board.Show();
                this.Visible = false;
            }
            else
            {
                label2.Text = "Invalid Username or Password.";
            }
        }

        private void buttreset_Click(object sender, EventArgs e)
        {

        }
    }
}
