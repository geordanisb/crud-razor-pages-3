using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UI.Pages;

public class Index : PageModel
{

    private readonly IEmployerRepository EmployerRepository;
    [BindProperty]
    public Domain.Entities.Employer NewEmployer { get; set; } = new Domain.Entities.Employer();
    
    public List<Employer> Employers { get; set; } = new List<Employer>();
    public Index(IEmployerRepository EmployerRepository)
    {
        this.EmployerRepository = EmployerRepository;
    }

    public async Task OnGetAsync()
    {
        this.Employers = await  this.EmployerRepository.GetAllEmployers();
        
    }
    
   

    /*public void OnPost()
    {
        EmployerRepository.AddEmployer(NewEmployer);
        RedirectToPage();
    }*/
    
}