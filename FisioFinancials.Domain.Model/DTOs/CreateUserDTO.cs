﻿namespace FisioFinancials.Domain.Model.DTOs;

public record CreateUserDTO
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
