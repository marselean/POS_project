using MongoDB.Bson;
using MongoDB.Driver;
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
    public partial class UserManagement : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("User");
        static IMongoCollection<Employee> collection = db.GetCollection<Employee>("employees");

        public void ReadAllDocuments()
        {
            List<Employee> list = collection.AsQueryable().ToList<Employee>();
            dataGridView1.DataSource = list;
            eid.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            ename.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            euser.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            epass.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            estat.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            eworkhr.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
            esalary.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
        }
        public UserManagement()
        {
            InitializeComponent();
            ReadAllDocuments();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            eid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            ename.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            euser.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            epass.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            estat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            eworkhr.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            esalary.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void create_Click(object sender, EventArgs e)
        {
            Employee employ = new Employee(ename.Text, euser.Text, epass.Text, estat.Text, Double.Parse(eworkhr.Text), Double.Parse(esalary.Text));
            collection.InsertOne(employ);
            ReadAllDocuments();
        }

        private void update_Click(object sender, EventArgs e)
        {
            var edit = Builders<Employee>.Update.Set("Name", ename.Text).Set("Username", euser.Text).Set("Password", epass.Text).Set("status", estat.Text).Set("workhours", eworkhr.Text).Set("salary", esalary.Text);
            collection.UpdateOne(employ => employ.ID == ObjectId.Parse(eid.Text), edit);
            ReadAllDocuments();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            collection.DeleteOne(employ => employ.ID == ObjectId.Parse(eid.Text));
            ReadAllDocuments();
        }
    }
}
