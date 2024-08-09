using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetShopWithMSIdentity.Models;

namespace PetShopWithMSIdentity.Data
{
    public class PetDataContext : DbContext
    {
        public PetDataContext (DbContextOptions<PetDataContext> options)
            : base(options)
        {
        }

        public DbSet<PetShopWithMSIdentity.Models.Cat> Cat { get; set; } = default!;
        public DbSet<PetShopWithMSIdentity.Models.Dog> Dog { get; set; } = default!;
    }
}
