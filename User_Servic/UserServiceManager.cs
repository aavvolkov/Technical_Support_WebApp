using System;
using User_Service.Models;
using Microsoft.EntityFrameworkCore;

namespace User_Service
{
    public class UserServiceManager : IUserManager
        {
            public void Add(User u)
            {
                Console.WriteLine("add");
                using var context = new UserDbContext();
                var entity = context.Task.Add(u);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }

            public void Delete(int id)
            {
                Console.WriteLine("delete");
                using var context = new UserDbContext();
                User u = new User {Id = id};
                var entity = context.Task.Remove(u);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }

            public void EditStatus(int id, UserWorkStatus uws)
            {
                Console.WriteLine("changeStatus");
                User u = new User {Id = id, WorkStatus = uws};
                using var context = new UserDbContext();
                var entity = context.Task.Update(u);
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


