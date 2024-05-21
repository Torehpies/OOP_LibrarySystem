using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    internal class Member
    {
        Member(int id, string name, string details, string department, string type) 
        {
            Id = id;
            Name = name;
            Details = details;
            Department = department;
            Type = type;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string Department { get; set; }
        public string Type { get; set; }

    }
}
