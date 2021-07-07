using User_Service.Models;

namespace User_Service
{
    public interface IUserManager
    {
        public void Add(User u);
        public void EditStatus(int id, UserWorkStatus uws);
        public void Delete(int id);

      

    }
}