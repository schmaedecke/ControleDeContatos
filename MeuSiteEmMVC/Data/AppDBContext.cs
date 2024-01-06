﻿

using MeuSiteEmMVC.Models;

namespace MeuSiteEmMVC.Data {
    public class AppDBContext : DbContext{
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) {
        
        }
        public DbSet<ContatoModel> Contatos { get; set; }

    }
}
    