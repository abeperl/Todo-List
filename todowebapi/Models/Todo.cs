using System;
using System.Collections.Generic;

namespace todowebapi.Models
{
    public partial class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public DateTime Dtcreated { get; set; }
        public string Usercreated { get; set; }
    }
}
