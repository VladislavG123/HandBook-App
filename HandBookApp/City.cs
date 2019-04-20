using System.Collections.Generic;

namespace HandBookApp.Pages
{
    public class City : Entity
    {
        public string Name { get; set; }
        public int Code { get; set; }

        public ICollection<Person> People { get; set; }
    }
}