using dataaccess;
using dataaccess.Models;
using Microsoft.Extensions.DependencyInjection;
using PgCtx;
using UnitTests.Mocks;

namespace UnitTests;

public class ListDoctorsByYearsExperienceTests
{
    private PgCtxSetup<HospitalContext> _setup = TestSetupHelper.CreateTestSetup();

    [Fact]
    public void ListDoctorsByYearsExperience_Finds_Correct_Order()
    {
        //Arrange
        var doctor1 = Constants.GetDoctor();
        var doctor2 = Constants.GetDoctor();
        var doctor3 = Constants.GetDoctor();
        doctor1.YearsExperience = 3;
        doctor2.YearsExperience = 123;
        doctor3.YearsExperience = 0;
        _setup.DbContextInstance.AddRange(doctor1, doctor2, doctor3);
        _setup.DbContextInstance.SaveChanges();
        
        //Act
        var result = _setup.ServiceProviderInstance.GetRequiredService<IRepository>().ListDoctorsByYearsExperience();
        
        //Assert
        var expected = new List<int>() { doctor3.Id, doctor1.Id, doctor2.Id };
        Assert.Equal(expected, result.Select(d => d.Id));
    }
}