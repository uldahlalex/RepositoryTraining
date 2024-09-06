using dataaccess;
using dataaccess.Models;

namespace DataAccess;

public class HospitalRespositoryExercises(HospitalContext context) : IRepository
{
    public List<Doctor> GetAllDoctors()
    {
        throw new NotImplementedException();
    }
    
}