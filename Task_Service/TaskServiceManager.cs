using System;
using Task_Service.Models;
using Microsoft.EntityFrameworkCore;


namespace Task_Service
{
    public class TaskServiceManager: ITaskManager
    {
        public void Create(Task t)
        {
            Console.WriteLine("add:"+t.Id);
            using var context = new TaskDbContext(); 
            var entity = context.Task.Add(t);
            entity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Console.WriteLine("delete:"+id);
            using var context = new TaskDbContext();
            Task t = new Task {Id = id};
            var entity = context.Task.Remove(t);
            entity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public void ChangeStatus(int id, TaskStatus ts)
        {
            Console.WriteLine("changeStatus:"+id);
            Task t = new Task {Id = id, Status = ts};
            using var context = new TaskDbContext(); 
            var entity = context.Task.Update(t);
            entity.State = EntityState.Modified;
            context.SaveChanges();
        }

        
    }
}



/*
public Address Get(int addressId)
{
using var context = new AddressDbContext();
var entity = context.Address.Find(addressId);
//  Console.WriteLine($"Id:{entity.Id}; Postcode:{entity.Postcode}; City:{entity.City}");
return entity;
}*/


