using dataaccess;
using Microsoft.Extensions.DependencyInjection;
using PgCtx;
using UnitTests.Mocks;

namespace UnitTests;

public class GetAllPatientsWhoHasHadTreatmentWithId
{
    
    private readonly PgCtxSetup<HospitalContext> _setup = TestSetupHelper.CreateTestSetup();


    [Fact]
    public void GetAllPatientsWhoHasTreatmentWithId_Correctly_Returns_List()
    {
        //Arrange
        var patient = Constants.GetPatient();
        var patient2 = Constants.GetPatient();
        var treatment = Constants.GetTreatment();
        var patientTreatment = Constants.GetPatientTreatment(patient, treatment);
        _setup.DbContextInstance.AddRange(patient, patient2, treatment, patientTreatment);
        _setup.DbContextInstance.SaveChanges();
        
        //Act
        var result = _setup.ServiceProviderInstance.GetRequiredService<IRepository>().GetAllPatientsWhoHasHadTreatmentWithId(treatment.Id);
        
        //Assert
        Assert.Equivalent(result.First(), patient);

    }
}