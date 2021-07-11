using JogosAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogosAPI.Context
{
    public class JogosContext : DbContext
    {
        public DbSet<Jogo> jogos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            //Add Connection String Here
            optionBuilder.UseSqlServer("");
        }
    }
}
