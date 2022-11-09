using BookingService.DataAccessLayer.Repositories.Interfaces;
using BookingService.DataAccessLayer.Repositories;
using BookingService.InfrastructureLayer.Data.Entities;

namespace BookingService.DataAccessLayer.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _db = default!;

        private bool disposed = false;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
        }

        private IRepository<ModelTest> _modelTestRepository = default!;
        public IRepository<ModelTest> ModelTestRepository
        {
            get
            {
                if (_modelTestRepository == null)
                {
                    _modelTestRepository = new Repository<ModelTest>(_db);
                }
                return _modelTestRepository;
            }
        }

        public int Commit()
        {
            return _db.SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
            return await _db.SaveChangesAsync(new CancellationToken());
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
