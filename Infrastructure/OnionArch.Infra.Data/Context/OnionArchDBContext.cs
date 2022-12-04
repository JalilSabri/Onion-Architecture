namespace OnionArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using OnionArch.Application.Domain.Models.Management;

public class OnionArchDBContext : DbContext
{
    public OnionArchDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {

    }

    DbSet<Course> courses { get; set; }
}