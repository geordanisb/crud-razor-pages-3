using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UI.Pages;

public class EditEmployer : PageModel
{
    private readonly IEmployerRepository  _repository;
    [BindProperty]
    public Employer e { get; set; }
    public EditEmployer(IEmployerRepository repository)
    {
        _repository = repository;
    }
    public async Task OnGetAsync(int Id)
    {
        e = await _repository.GetEmployer(Id);
    }
    
    public async Task<IActionResult> OnPostAsync()
    {
        await _repository.UpdateEmployer(e);
        return RedirectToPage("/Index");
    }

}