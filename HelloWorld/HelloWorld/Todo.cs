using System;

namespace Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public DateTime Dtcreated { get; set; }
        public string Usercreated { get; set; }
        public DateTime DTModified { get; set; }
    }
}
