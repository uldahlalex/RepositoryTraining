using dataaccess;
using dataaccess.Models;
using Microsoft.EntityFrameworkCore;
using service.responses;

namespace DataAccess.Solutions;

/// <summary>
/// If you're stuck or are curious how the implementation can be built, here I have some solutions
/// </summary>
/// <param name="context"></param>
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

    public Doctor GetDoctorWhoMadeMostDiagnoses()
    {
        return context.Doctors.OrderByDescending(d => d.Diagnoses.Count).First();
    }

    public List<Patient> GetAllPatientsWhoHasHadTreatment(int treatmentId)
    {
        return context.Patients.Where(p => p.PatientTreatments.Any(t => t.TreatmentId == treatmentId)).ToList();
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