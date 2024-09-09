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

    public List<Doctor> GetAllDoctorsIncludingDiagnoses()
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

    public List<Patient> GetAllPatientsWhoHasHadTreatmentWithId(int treatmentId)
    {
        return context.Patients.Where(p => p.PatientTreatments.Any(t => t.TreatmentId == treatmentId)).ToList();
    }

    public List<Doctor> GetAllDoctorsWithSpecialty(string specialty)
    {
        return context.Doctors.Where(d => d.Specialty.Equals(specialty)).ToList();
    }

    public List<Doctor> ListDoctorsByYearsExperience()
    {
        return context.Doctors.OrderBy(d => d.YearsExperience).ToList();
    }

    public int GetTotalNumberOfDoctors()
    {
        return context.Doctors.Count();
    }

    public string GetNameOfMostUsedTreatment()
    {
        return context.Treatments
            .OrderByDescending(t => t.PatientTreatments.Count)
            .First().Name;
    }
}