using dataaccess;
using dataaccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Solutions;

public class HospitalRepositorySolutions(HospitalContext context) : IRepository
{
    public List<Doctor> GetAllDoctors()
    {
        return context.Doctors.ToList();
    }
}