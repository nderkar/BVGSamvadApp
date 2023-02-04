using Samvad_App.Server.Models;
using Samvad_App.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection.Emit;

namespace Samvad_App.Server.Data
{

	

	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext(DbContextOptions options) : base(options){}

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<PostAsset> PostAsset { get; set; }
        //public DbSet<PostAsset> PostLike { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
		{
            //builder.Entity<PostLike>()
            //.HasRequired<Post>(s => s.CurrentGrade)
            //.WithMany(g => g.Students)
            //.HasForeignKey<int>(s => s.CurrentGradeId);

            base.OnModelCreating(builder);

			builder.Entity<IdentityRole>()
				   .HasData(new IdentityRole { Name = "User", NormalizedName = "USER", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
			builder.Entity<IdentityRole>()
				   .HasData(new IdentityRole { Name = "Admin", NormalizedName = "ADMIN", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
		}
	}
}
