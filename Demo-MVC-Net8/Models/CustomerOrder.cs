﻿namespace Demo_MVC_Net8.Models
{
    public class CustomerOrder
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Description { get; set; }
        public decimal Total { get; set; }
    }
}