﻿using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        {

        }
    }
}
