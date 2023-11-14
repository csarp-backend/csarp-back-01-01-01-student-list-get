using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Repos
{
    public class TeacherRepo : ITeacherRepo
    {
        private readonly KretaContext _dbContext;

        public TeacherRepo(KretaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Teacher>> GetAll()
        {
            return await _dbContext.Teachers.ToListAsync();
        }

        public async Task<Teacher?> GetBy(Guid id)
        {
            return await _dbContext.Teachers.FirstOrDefaultAsync(s => s.Id == id);
        }
    }
}
