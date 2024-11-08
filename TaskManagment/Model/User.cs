﻿namespace TaskManagment.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

       public ICollection<TaskItem>? TaskItems { get; set; }
        public Address Address { get;  set; }
        
    }
}
