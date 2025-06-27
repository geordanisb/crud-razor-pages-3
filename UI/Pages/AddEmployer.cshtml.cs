using Application.Interfaces;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UI.ViewComponents;

namespace UI.Pages;

public class AddEmployer : PageModel
{

    private readonly IEmployerRepository EmployerRepository;
    [BindProperty]
    public Domain.Entities.Employer NewEmployer { get; set; } = new Domain.Entities.Employer();
    
    public AddEmployer(IEmployerRepository EmployerRepository)
    {
        this.EmployerRepository = EmployerRepository;
    }
    public void OnGet()
    {
        
    }

    public IActionResult OnPost()
    {
        EmployerRepository.AddEmployer(NewEmployer);
        return  RedirectToPage("/Index");
    }
    
}