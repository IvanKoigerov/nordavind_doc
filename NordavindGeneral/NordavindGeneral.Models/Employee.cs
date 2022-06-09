using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordavindGeneral.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public Position Position { get; set; }
        public string Status { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Chief { get; set; }
    }
}