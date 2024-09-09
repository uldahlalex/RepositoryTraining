using dataaccess;
using dataaccess.Models;
using Microsoft.Extensions.DependencyInjection;
using PgCtx;
using UnitTests.Mocks;

namespace UnitTests;

public class GetAllDoctorsWithSpecialityTests
{
    public PgCtxSetup<HospitalContext> _setup = TestSetupHelper.CreateTestSetup();

    [Fact]
    public void GetAllDoctorsWithSpeciality_Returns_Doctors_WithSpeciality()
    {
        //Arrange
        var doctor1 = Constants.GetDoctor();
        var doctor2 = Constants.GetDoctor();
        
        doctor1.Specialty = "Cardiologist";
        doctor2.Specialty = "Urologist";
        
        _setup.DbContextInstance.AddRange(doctor1, doctor2);
        _setup.DbContextInstance.SaveChanges();
        
        //Act
        var result = _setup.ServiceProviderInstance.GetRequiredService<IRepository>().GetAllDoctorsWithSpecialty("Cardiologist");
        
        //Assert
        Assert.Equivalent(result.First(), doctor1);
    }
}