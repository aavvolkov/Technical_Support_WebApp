using System;
using Task_Service.Models;
using Microsoft.EntityFrameworkCore;

namespace Task_Service
{
    public class TaskServiceManager: ITaskManager
    {
        public void Create(Task task)
        {
            using var context = new TaskDbContext(); 
            var entity = context.Tasks.Add(task);
            entity.State = EntityState.Added;
            context.SaveChanges();
            Console.WriteLine("add:"+task.Id+" createdDate:"+DateTime.Now.ToUniversalTime());
        }

        public void Delete(int id)
        {
            Console.WriteLine("delete:"+id+" deletedDate:"+DateTime.Now.ToUniversalTime());
            using var context = new TaskDbContext();
            var task = new Task {Id = id};
            var entity = context.Tasks.Remove(task);
            entity.State = EntityState.Deleted;
            
            try
            {
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }

        public void ChangeStatus(int id, TaskStatus taskStatus)
        {
            Console.WriteLine("changeStatus:"+id+" status"+taskStatus);
            var task = new Task {Id = id, Status = taskStatus};
            using var context = new TaskDbContext(); 
            var entity = context.Tasks.Update(task);
            entity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}

