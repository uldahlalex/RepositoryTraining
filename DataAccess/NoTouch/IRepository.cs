using dataaccess.Models;
using service.responses;

namespace dataaccess;

public interface IRepository
{
    public List<Doctor> GetAllDoctors();

    public List<DoctorDto> GetAllDoctorsAsDtos();

    /// <summary>
    /// Order ascending
    /// </summary>
    /// <returns></returns>
    public List<Doctor> ListDoctorsByYearsExperience();

    public int GetTotalNumberOfDoctors();

    /// <summary>
    /// Diagnoses are a property for a doctor object which must be included here
    /// </summary>
    /// <returns></returns>
    public List<Doctor> GetAllDoctorsIncludingDiagnoses();

    public Doctor GetDoctorWhoMadeMostDiagnoses();
    public List<Doctor> GetAllDoctorsWithSpecialty(string specialty);


    public List<Patient> GetAllPatientsWhoHasHadTreatmentWithId(int treatmentId);

    public string GetNameOfMostUsedTreatment();
}