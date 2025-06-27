using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesTezt.Pages.Shared;

public class DeleteEmployer : PageModel
{
    private readonly IEmployerRepository _repository;
    public Employer? Employer { get; set; }
    public DeleteEmployer(IEmployerRepository repository)
    {
        _repository = repository;
    }
    public async Task OnGetAsync(int Id)
    {
        Employer = await _repository.GetEmployer(Id);
    }

    public async Task<IActionResult> OnPostAsync(int Id)
    {
        await _repository.DeleteEmployer(Id);
        return  RedirectToPage("/Index");
    }
}