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
        public String username { get; set; }
        
        [BsonElement("Password")]
        public String password { get; set; }

        [BsonElement("status")]
        public String status { get; set; }

        [BsonElement("workhours")]
        public Double workhours { get; set; }
        
        [BsonElement("salary")]
        public Double salary { get; set; }

        public Employee(string name, string username, string password, string status, double workhours, double salary)
        {
            this.name = name;
            this.username = username;
            this.password = password;
            this.status = status;
            this.workhours = workhours;
            this.salary = salary;
        }
    }
}
