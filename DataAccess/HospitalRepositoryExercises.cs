﻿using dataaccess;
using dataaccess.Models;
using service.responses;

namespace DataAccess;

public class HospitalRepositoryExercises(HospitalContext context) : IRepository
{
    public List<Doctor> GetAllDoctors()
    {
        throw new NotImplementedException();
    }

    public List<Doctor> GetAllDoctorsWithDiagnosesMade()
    {
        throw new NotImplementedException();
    }

    public List<DoctorDto> GetAllDoctorsAsDtos()
    {
        throw new NotImplementedException();
    }

    public Doctor GetDoctorWhoMadeMostDiagnoses()
    {
        throw new NotImplementedException();
    }

    public List<Patient> GetAllPatientsWhoHasHadTreatment(int treatmentId)
    {
        throw new NotImplementedException();
    }

    public List<Doctor> GetAllDoctorsWithSpecialty(string specialty)
    {
        throw new NotImplementedException();
    }

    public List<Doctor> ListDoctorsByYearsExperience(int yearsExperience)
    {
        throw new NotImplementedException();
    }

    public int GetTotalNumberOfDoctors()
    {
        throw new NotImplementedException();
    }

    public string GetNameOfMostUsedTreatment()
    {
        throw new NotImplementedException();
    }
}