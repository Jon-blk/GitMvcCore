using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitMvcCore.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Person Driver { get; set; }
        public List<Person> Passengers { get; set; }
    }
}
