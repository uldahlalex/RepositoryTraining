using dataaccess;
using Microsoft.Extensions.DependencyInjection;
using PgCtx;
using UnitTests.Mocks;

namespace UnitTests;

public class GetTotalNumberOfDoctorsTests
{
    private PgCtxSetup<HospitalContext> _setup = TestSetupHelper.CreateTestSetup();

    [Fact]
    public void GetTotalNumberOfDoctors_Correctly_Finds_Total_Number_Of_Doctors()
    {
        //Arrange

        var doctor = Constants.GetDoctor();
        var doctor2 = Constants.GetDoctor();
        
        _setup.DbContextInstance.AddRange(doctor, doctor2);
        _setup.DbContextInstance.SaveChanges();
        
        //Act
        var result = _setup.ServiceProviderInstance.GetRequiredService<IRepository>().GetTotalNumberOfDoctors();
        
        //Assert
        Assert.Equal(2, result);
    }
}