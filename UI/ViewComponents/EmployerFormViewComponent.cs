using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents;

public class EmployerFormModel
{
    public bool IsEdit { get; set; } = false;
    public Employer? employer{get;set;}
}

public class EmployerFormViewComponent:ViewComponent
{
    private readonly IEmployerRepository EmployerRepository;
    public EmployerFormViewComponent(IEmployerRepository employerRepository)
    {
        this.EmployerRepository = employerRepository;
    }
    public IViewComponentResult Invoke(EmployerFormModel  model)
    {
        return View(model);
    }
}