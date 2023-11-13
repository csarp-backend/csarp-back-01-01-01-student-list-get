using Kreata.Backend.Datas.Entities;

namespace Kreata.Backend.Repos
{
    public interface ITeacherRepo
    {
        List<Teacher> GetAll();
        Teacher? GetBy(Guid id);
    }
}
