using System;
using Common;

namespace User_Authorization_Service.Models
{
    public class User: IDomainEntity
    {
        public int Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public Fio Fio { get; set; } 
        public int GroupId { get; set; } 
        public UserWorkStatus WorkStatus { get; set; }
    }
    
    
    
    
}



