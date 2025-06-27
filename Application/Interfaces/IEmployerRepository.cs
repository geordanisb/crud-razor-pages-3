

using Domain.Entities;

namespace Application.Interfaces;

public interface IEmployerRepository
{
    Task AddEmployer(Employer employer);
    Task<List<Employer>> GetAllEmployers();
    Task<Employer> GetEmployer(int Id);
    Task UpdateEmployer(Employer employer);
    Task DeleteEmployer(int Id);
    int CountEmployersActives();
}