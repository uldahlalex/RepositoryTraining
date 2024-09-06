using dataaccess;
using dataaccess.Models;
using Microsoft.EntityFrameworkCore;
using service.responses;

namespace DataAccess.Solutions;

public class HospitalRepositorySolutions(HospitalContext context) : IRepository
{
    public List<Doctor> GetAllDoctors()
    {
        return context.Doctors.ToList();
    }

    public List<Doctor> GetAllDoctorsWithDiagnosesMade()
    {
        return context.Doctors.Include(d => d.Diagnoses).ToList();
    }

    public List<DoctorDto> GetAllDoctorsAsDtos()
    {
        return context.Doctors.Select(d => new DoctorDto().FromEntity(d)).ToList();
    }

    public Doctor GetDoctorWhoMadeMostDianoses()
    {
        throw new NotImplementedException();
    }

    public List<Patient> GetAllPatientsWhoHasDoctorWithId(int doctorId)
    {
        throw new NotImplementedException();
    }

    public List<Doctor> GetAllDoctorsWithSpecialty(string specialty)
    {
        throw new NotImplementedException();
    }

    public List<Doctor> ListDoctorsByYearsExperience(int yearsExperience)
    {
        throw new NotImplementedException();
    }

    public int GetTotalNumberOfDoctors()
    {
        throw new NotImplementedException();
    }

    public string GetNameOfMostUsedTreatment()
    {
        throw new NotImplementedException();
    }
}