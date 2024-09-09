using dataaccess.Models;
using service.responses;

namespace dataaccess;

public interface IRepository
{
    public List<Doctor> GetAllDoctors();
    public List<Doctor> GetAllDoctorsWithDiagnosesMade();
    public List<DoctorDto> GetAllDoctorsAsDtos();
    public Doctor GetDoctorWhoMadeMostDiagnoses();
    public List<Patient> GetAllPatientsWhoHasHadTreatment(int treatmentId);
    public List<Doctor> GetAllDoctorsWithSpecialty(string specialty);
    public List<Doctor> ListDoctorsByYearsExperience(int yearsExperience);
    public int GetTotalNumberOfDoctors();
    public string GetNameOfMostUsedTreatment();
    
}