using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeStudProfDept.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Professor(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
