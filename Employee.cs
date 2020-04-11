using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_project
{
    class Employee
    {
        [BsonId]
        public ObjectId ID { get; set; }
        [BsonElement("Name")]
        public String name { get; set; }
        [BsonElement("Username")]
        public string username { get; set; }
        [BsonElement("Password")]
        public string password { get; set; }
        [BsonElement("WorkHours")]
        public int workhours { get; set; }
        [BsonElement("Salary")]
        public double salary { get; set; }

        public Employee(string name, string username, string password, int workhours, double salary)
        {
            this.name = name;
            this.username = username;
            this.password = password;
            this.workhours = workhours;
            this.salary = salary;
        }
    }
}
