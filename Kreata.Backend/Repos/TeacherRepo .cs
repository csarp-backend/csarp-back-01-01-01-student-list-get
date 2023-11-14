using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;

namespace Kreata.Backend.Repos
{
    public class TeacherRepo : ITeacherRepo
    {
        private readonly KretaContext _dbContext;

        public TeacherRepo(KretaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Teacher> GetAll()
        {
            return _dbContext.Teachers.ToList();
        }

        public Teacher? GetBy(Guid id)
        {
            return _dbContext.Teachers.FirstOrDefault(s => s.Id == id);
        }
    }
}
