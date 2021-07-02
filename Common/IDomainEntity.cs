using System;

namespace Common
{
    public interface IDomainEntity
    {

        public int Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }


    }
}