using User_Service.Models;

namespace User_Service
{
    public interface IUserManager
    {
        public void Add(User user);
        public void EditStatus(int id, UserWorkStatus workStatus);
        public void Delete(int id);

      

    }
}