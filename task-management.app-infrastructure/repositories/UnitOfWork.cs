using task_management.app_application.interfaces;

namespace task_management.app_infrastructure.repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ITaskRepository taskRepository)
        {
            Tasks = taskRepository;
        }
        public ITaskRepository Tasks { get; }
    }
}
