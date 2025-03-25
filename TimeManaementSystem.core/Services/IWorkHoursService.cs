using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManaementSystem.Core.Entities;

namespace TimeManaementSystem.Core.Services
{
    public interface IWorkHoursService
    {
       Task<List<WorkHours>> GetListAsync();
        Task<WorkHours?> GetByIdAsync(int id);
        Task<WorkHours> AddAsync(WorkHours workhours);
        Task<WorkHours> UpdateAsync(WorkHours workhours);
        Task DeleteAsync(int id);
    }
}
