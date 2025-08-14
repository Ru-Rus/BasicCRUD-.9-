using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BasicCRUD_._9_.Model;

namespace BasicCRUD_._9_.Data
{
    public class BasicCRUD__9_Context : DbContext
    {
        public BasicCRUD__9_Context (DbContextOptions<BasicCRUD__9_Context> options)
            : base(options)
        {
        }

        public DbSet<BasicCRUD_._9_.Model.User> User { get; set; } = default!;
    }
}
