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
        public DbSet<PostLike> PostLike { get; set; }
        public DbSet<PostComment> PostComment { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
		{		

			base.OnModelCreating(builder);

            //builder.Entity<PostLike>()
            //  .HasOne<Post>(s => s.currentPost)
            //  .WithMany(g => g.postlikes)
            //  .HasForeignKey(s => s.currentPostid);

            //builder.Entity<PostLike>()
            //  .HasOne<ApplicationUser>(s => s.userid)
            //  .WithOne(g => g.)
            //  .HasForeignKey(s => s.currentPostid);

            builder.Entity<IdentityRole>()
				   .HasData(new IdentityRole { Name = "User", NormalizedName = "USER", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
			builder.Entity<IdentityRole>()
				   .HasData(new IdentityRole { Name = "Admin", NormalizedName = "ADMIN", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
		}
	}
}
