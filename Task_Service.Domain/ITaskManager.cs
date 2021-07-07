using Task_Service.Models;

namespace Task_Service
{
    public interface ITaskManager
    {
        public void Create(Task t);
        public void Delete(int id);
        public void ChangeStatus(int id, TaskStatus ts);

    }
}