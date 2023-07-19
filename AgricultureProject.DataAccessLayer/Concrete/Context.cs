using AgricultureProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureProject.DataAccessLayer.Concrete
{
	public class Context : IdentityDbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=DESKTOP-9H60TTH\\SERCANKURBAN;Initial Catalog=DbCoreAgriculture;User ID=WebMobile_302;Password=webmobile.302");
		}
		public DbSet<Address> Addresses { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Image> Images { get; set; }
		public DbSet<Announcement> Announcements { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<Team> Teams { get; set; }
		public DbSet<SocialMedia> SocialMedias { get; set; }
		public DbSet<About> Abouts { get; set; }
		public DbSet<Admin> Admins { get; set; }
	}
}
