﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace VLGroupWebSite.Repository.Concrete.EntityFramework
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<VLGroupContext>
    {
        public VLGroupContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<VLGroupContext>();
            var connectionstring = configuration.GetConnectionString("cString");
            builder.UseSqlServer(connectionstring);
            return new VLGroupContext(builder.Options);
        }
    }
}
