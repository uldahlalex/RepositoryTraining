using Bogus;
using dataaccess.Models;

namespace UnitTests.Mocks;

public class Constants
{
    
    public static Patient GetPatient()
    {
        return new Faker<Patient>()
            .RuleFor(p => p.Name, f => f.Name.FullName())
            .RuleFor(p => p.Address, f => f.Address.FullAddress())
            .RuleFor(p => p.Birthdate, f => f.Date.PastDateOnly())
            .RuleFor(p => p.Gender, f => true);
    }
    
    public static Doctor GetDoctor()
    {
        return new Faker<Doctor>()
            .RuleFor(d => d.YearsExperience, f => f.Random.Int(1, 20))
            .RuleFor(d => d.Specialty, f => f.Lorem.Word())
            .RuleFor(d => d.Name, f => f.Name.FullName());
    }

    public static Disease GetDisease()
    {
        return new Faker<Disease>()
            .RuleFor(d => d.Severity, f => f.Lorem.Word())
            .RuleFor(d => d.Name, f => f.Lorem.Word());
    }
    
    public static Diagnosis GetDiagnosis(Doctor doctor, Patient patient, Disease disease)
    {
        return new Faker<Diagnosis>()
            .RuleFor(d => d.DiagnosisDate, f => DateTime.UtcNow)
            .RuleFor(d => d.Disease, f => disease)
            .RuleFor(d => d.Doctor, f => doctor)
            .RuleFor(d => d.Patient, f => patient);
    }
}