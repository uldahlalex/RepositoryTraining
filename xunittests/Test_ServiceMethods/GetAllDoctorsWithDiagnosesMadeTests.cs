using dataaccess;
using DataAccess;
using dataaccess.Models;
using Microsoft.Extensions.DependencyInjection;
using PgCtx;
using UnitTests.Mocks;

namespace UnitTests;

public class GetAllDoctorsWithDiagnosesMadeTests
{
    private readonly HospitalContext _db;
    private readonly PgCtxSetup<HospitalContext> _setup;


    public GetAllDoctorsWithDiagnosesMadeTests()
    {
        _setup = TestSetupHelper.CreateTestSetup();
        _db = _setup.DbContextInstance;
    }
    
    [Fact]
    public void GetAllDoctorsWithDiagnosesMade_ReturnsAllDoctorsWithDiagnoses()
    {
        // Arrange
        var doctor = Constants.GetDoctor();
        var patient = Constants.GetPatient();
        var disease = Constants.GetDisease();
        var diagnosis = Constants.GetDiagnosis(doctor, patient, disease);
        _db.AddRange(doctor,patient,disease,diagnosis);
        _db.SaveChanges();
            
        
        
        // A
        var result =_setup.ServiceProviderInstance.GetRequiredService<IRepository>().GetAllDoctorsIncludingDiagnoses();
        
        // Assert
        var expectedDate = diagnosis.DiagnosisDate;
        var actualDate = result.First().Diagnoses.First().DiagnosisDate;
        Assert.True((actualDate - expectedDate).Value.Duration() < TimeSpan.FromSeconds(1), 
            "The diagnosis dates should be within 1 second of each other.");
    }
}