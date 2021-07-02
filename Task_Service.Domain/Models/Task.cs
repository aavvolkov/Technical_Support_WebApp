using System;
using Common;

namespace Task_Service.Models
{
    public class Task: IDomainEntity
    {
        public int Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string Title { get; set; } 
        public string Description { get; set; } 
        public TaskStatus Status { get; set; }
        public int CreatorId { get; set; }
        public int AssignedId { get; set; }
        
    }
}



