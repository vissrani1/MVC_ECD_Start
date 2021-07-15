using Microsoft.EntityFrameworkCore;
using MVC_ECD_Start.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_ECD_Start.Data
{
    public partial class StudentDBContext: DbContext
    {
        public StudentDBContext()

        {



        }



        public StudentDBContext(DbContextOptions<StudentDBContext> options)

            : base(options)

        {

        }



        public virtual DbSet<CollegeData> CollegesData { get; set; }

    }
}
