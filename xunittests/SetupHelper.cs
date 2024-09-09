using dataaccess;
using DataAccess;
using DataAccess.Solutions;
using Microsoft.Extensions.DependencyInjection;
using PgCtx;


public static class TestSetupHelper
{
    public static PgCtxSetup<HospitalContext> CreateTestSetup()
    {
        bool useSolution = Environment.GetEnvironmentVariable("USE_SOLUTION")?.ToLower() == "true";

        return new PgCtxSetup<HospitalContext>(configureServices: services =>
        {
            if (useSolution)
            {
                services.AddTransient<IRepository, HospitalRepositorySolutions>();
            }
            else
            {
                services.AddTransient<IRepository, HospitalRepositoryExercises>();
            }
        });
    }
}