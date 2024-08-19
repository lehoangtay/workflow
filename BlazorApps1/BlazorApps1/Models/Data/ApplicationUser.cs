using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
    public string Name { get; set; }
    public string Code { get; set; }
    public string Role { get; set; } = "User"; // Thi?t l?p giá tr? m?c ??nh cho Role
}
