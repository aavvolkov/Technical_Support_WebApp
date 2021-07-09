using System;
using User_Service.Models;
using Microsoft.EntityFrameworkCore;

namespace User_Service
{
    public class UserServiceManager : IUserManager
        {
            public void Add(User user)
            {
                using var context = new UserDbContext();
                var entity = context.Users.Add(user);
                entity.State = EntityState.Added;
                string newId = user.Id.ToString();
                context.SaveChanges();
                Console.WriteLine("add Id:"+newId+" createdDate:"+DateTime.Now.ToUniversalTime());
            }

            public void Delete(int id)
            {
                Console.WriteLine("delete Id:"+id+" deletedDate:"+DateTime.Now.ToUniversalTime());
                using var context = new UserDbContext();
                var user = new User {Id = id};
                var entity = context.Users.Remove(user);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }

            public void EditStatus(int id, UserWorkStatus workStatus)
            {
                Console.WriteLine("changeStatus Id:"+id+" status:"+workStatus);
                var user = new User {Id = id, WorkStatus = workStatus};
                using var context = new UserDbContext();
                var entity = context.Users.Update(user);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }

