using Task_Service.Models;

namespace Task_Service
{
    public interface ITaskManager
    {
        public void Create(Task t);
        public void Edit(Task t);
        public void Delete(Task t);
        
        //public TaskStatus ChangeStatus(Task t);
        //public void ChangeAssignedUser(Task t);
        
        
        
        
        
        
    }
}