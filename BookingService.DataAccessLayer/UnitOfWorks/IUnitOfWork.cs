using BookingService.DataAccessLayer.Repositories.Interfaces;
using BookingService.InfrastructureLayer.Data.Entities;

namespace BookingService.DataAccessLayer.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IRepository<ModelTest> ModelTestRepository { get; }

        Task<int> CommitAsync();
        int Commit();
    }
}
