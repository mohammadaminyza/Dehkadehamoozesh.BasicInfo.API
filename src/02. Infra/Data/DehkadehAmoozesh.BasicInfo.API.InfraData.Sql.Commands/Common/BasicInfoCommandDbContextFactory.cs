using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DehkadehAmoozesh.BasicInfo.API.InfraData.Sql.Commands.Common;

class BasicInfoCommandDbContextFactory : IDesignTimeDbContextFactory<BasicInfoCommandDbContext>
{
    public BasicInfoCommandDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<BasicInfoCommandDbContext>();
        optionsBuilder.UseSqlServer("server=.; Database=Dev-DehkadehAmoozeshBasicInfo; User Id=sa; Password=123456; MultipleActiveResultSets=true");

        return new BasicInfoCommandDbContext(optionsBuilder.Options);
    }
}