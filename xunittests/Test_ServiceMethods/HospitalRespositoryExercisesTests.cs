using System.Text.Json;
using dataaccess;
using DataAccess;
using dataaccess.Models;
using Microsoft.Extensions.DependencyInjection;
using PgCtx;
using service.responses;
using UnitTests.Mocks;
using Xunit.Abstractions;

namespace UnitTests;

public class HospitalRespositoryExercisesTests
{
    private readonly PgCtxSetup<HospitalContext> _setup;

    public HospitalRespositoryExercisesTests(ITestOutputHelper outputHelper)
    {
        _setup = TestSetupHelper.CreateTestSetup();
    }

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

    [Fact]
    public void GetAllDoctorsAsDtos_ReturnsAllDoctsAsDtos()
    {
        //arrange
        var doctors = new List<Doctor>
        {
            Constants.GetDoctor(),
            Constants.GetDoctor()
        };
    
        _setup.DbContextInstance.Doctors.AddRange(doctors);
        _setup.DbContextInstance.SaveChanges();
        //Act
        var result = _setup.ServiceProviderInstance.GetRequiredService<IRepository>().GetAllDoctorsAsDtos();
        
        //Assert
        var expected  = doctors.Select(d => new DoctorDto()
        {
            YearsExperience = d.YearsExperience,
            Id = d.Id,
            Name = d.Name,
            Specialty = d.Specialty
        });
        Assert.Equivalent(expected, result);
        
    }
}