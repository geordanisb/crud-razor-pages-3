namespace Core.Domain;

public class Employer
{
    public string Name { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;   
    public string Area { get; private set; } = string.Empty;
    public DateTime StartDate { get; private set; } = DateTime.Today;
    public bool Active { get; private set; } 
}