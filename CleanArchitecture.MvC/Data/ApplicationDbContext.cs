﻿using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.MvC.Data
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
    }
}
