using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents;

public class EmployersStatusDetailsModel
{
    public int qtyActives { get; set; }
    public int qtyNonActives { get; set; }
}

public class EmployersStatusDetailsViewComponent:ViewComponent
{
    private readonly IEmployerRepository EmployerRepository;
    public EmployersStatusDetailsViewComponent(IEmployerRepository employerRepository)
    {
        this.EmployerRepository = employerRepository;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var qtyActives = EmployerRepository.CountEmployersActives();
        var cena = await EmployerRepository.GetAllEmployers();
        var qtyNonActives = cena.Count -  qtyActives;
        return View(new EmployersStatusDetailsModel{qtyNonActives=qtyNonActives, qtyActives=qtyActives});
    }
}