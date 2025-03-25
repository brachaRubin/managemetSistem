using TimeManaementSystem.Core.Entities;
using TimeManaementSystem.Core.Repositories;
using TimeManaementSystem.Core.Services;

namespace TimeManagementSystem.Service
{
    public class WorkHoursService : IWorkHoursService
    {
        private readonly IRepository<WorkHours> _workHoursRepository;
        public WorkHoursService(IRepository<WorkHours> workHoursRepository)
        {
            _workHoursRepository = workHoursRepository;
        }

        public async Task<WorkHours> AddAsync(WorkHours workhours)
        {
            return await _workHoursRepository.AddAsync(workhours);
        }

        public async Task DeleteAsync(int id)
        {
            await _workHoursRepository.DeleteAsync(id);
        }

        public async Task<WorkHours?> GetByIdAsync(int id)
        {
            return await _workHoursRepository.GetByIdAsync(id);
        }

        public async Task<List<WorkHours>> GetListAsync()
        {
            return (await _workHoursRepository.GetAllAsync()).ToList();
        }

        public async Task<WorkHours> UpdateAsync(WorkHours workhours)
        {
            return await _workHoursRepository.UpdateAsync(workhours);
        }
    }
}