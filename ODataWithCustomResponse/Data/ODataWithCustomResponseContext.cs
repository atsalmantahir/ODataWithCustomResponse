using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ODataWithCustomResponse.Entities;

namespace ODataWithCustomResponse.Data
{
    public class ODataWithCustomResponseContext : DbContext
    {
        public ODataWithCustomResponseContext (DbContextOptions<ODataWithCustomResponseContext> options)
            : base(options)
        {
        }

        public DbSet<ODataWithCustomResponse.Entities.Products> Products { get; set; }
    }
}
