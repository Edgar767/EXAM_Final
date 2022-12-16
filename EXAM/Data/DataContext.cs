using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using EXAM.Models;


namespace EXAM.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<EXAM.Models.User> User { get; set; } = default!;

        public DbSet<EXAM.Models.Category> Category { get; set; }

        public DbSet<EXAM.Models.Question> Question { get; set; }

        public DbSet<EXAM.Models.QuestionAnswer> QuestionAnswer { get; set; }

        public DbSet<EXAM.Models.Role> Role { get; set; }

        public DbSet<EXAM.Models.Survey> Survey { get; set; }

        public DbSet<EXAM.Models.UserAnswer> UserAnswer { get; set; }
    }
}
