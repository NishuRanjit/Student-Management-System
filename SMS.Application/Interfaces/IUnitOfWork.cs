namespace SMS.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IStudentRepository Students { get; }
        Task SaveAsync();

    }
}
