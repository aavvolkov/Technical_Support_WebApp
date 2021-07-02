using Task_Service.Models;
using User_Authorization_Service.Models;

namespace User_Authorization_Service
{
    public interface IUserManager
    {
        public void Add(User u);
        public void Edit(User u);
        public void Delete(User u);

        public int CountTasks(string status, Task t);

    }
}