namespace task_management.app_application.interfaces
{
    public interface IUnitOfWork
    {
        ITaskRepository Tasks { get; }
    }
}
