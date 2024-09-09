using dataaccess;
using dataaccess.Models;
using Microsoft.Extensions.DependencyInjection;
using PgCtx;
using UnitTests.Mocks;

namespace UnitTests;

public class GetAllDoctorsTest
{
    
    private readonly PgCtxSetup<HospitalContext> _setup = TestSetupHelper.CreateTestSetup();

    
    [Fact]
    public void GetAllDoctors_ReturnsAllDoctors()
    {
        var doctors = new List<Doctor>
        {
            Constants.GetDoctor(),
            Constants.GetDoctor()
        };
        _setup.DbContextInstance.Doctors.AddRange(doctors);
        _setup.DbContextInstance.SaveChanges();

        var result =_setup.ServiceProviderInstance.GetRequiredService<IRepository>().GetAllDoctors();

        Assert.Equivalent(doctors, result);
    }

}