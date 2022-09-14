﻿namespace Task.Models
{
    public class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Client> Clients { get; set; }
    }
}