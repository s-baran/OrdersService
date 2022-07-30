using System;

namespace OrdersService.DB.DatabaseModels
{
    public class DBOrder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime CreationTime { get; set; }
    }
}