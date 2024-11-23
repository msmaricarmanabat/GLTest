namespace GLTest.Core.Common
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void CommitTransaction();
        void Rollback();
        Task StartTransaction();
    }
}
