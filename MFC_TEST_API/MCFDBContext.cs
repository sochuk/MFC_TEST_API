using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using MCF_TEST_API.Models;
using Microsoft.EntityFrameworkCore;

namespace MCF_TEST_API
{
    public class MCFDBContext : DbContext
    {
        public MCFDBContext(DbContextOptions options) : base(options) { }
        public DbSet<MstStorageLocation> MstStorageLocations { get; set; }
        public DbSet<TrBpkb> TrBpkbs { get; set; }
    }
}

