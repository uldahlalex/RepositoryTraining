using dataaccess.Models;

namespace dataaccess;

public interface IRepository
{
    public List<Doctor> GetAllDoctors();
}