using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class EmployerRepository:IEmployerRepository
{
    readonly AppDbContext _context;


    public EmployerRepository(AppDbContext _context)
    {
        this._context = _context;
    }
    public async Task AddEmployer(Employer employer)
    {
        var Id = _context.Employers.Count()+1;
        employer.Id = Id;
        _context.Employers.Add(employer);
        await _context.SaveChangesAsync();
    }

    public Task<List<Employer>> GetAllEmployers()
    {
        return _context.Employers.ToListAsync();
    }

    public async Task<Employer> GetEmployer(int Id)
    {
        var e = await _context.Employers.FindAsync(Id);
        return e;
    }

    public async Task UpdateEmployer(Employer employer)
    {
        _context.Employers.Update(employer);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteEmployer(int Id)
    {
        var e = await _context.Employers.FindAsync(Id);
        _context.Employers.Remove(e);
        await _context.SaveChangesAsync();
    }

    public int CountEmployersActives()
    {
        var total =    _context.Employers
            .Where(e=>e.Active)
            .Select(e=>e.Id)
            .Count();
        return total;
    }
}