using JogosAPI.Context;
using JogosAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JogosAPI.Repositories
{
    public class JogoSqlServerRepository : IJogoRepository
    {
        private readonly JogosContext _db;

        public JogoSqlServerRepository(IConfiguration configuration, JogosContext db )
        {
            _db = db;
        }

        public async Task<List<Jogo>> Obter()
        {
            var jogos = await _db.jogos.ToListAsync();
            return jogos;
        }

        public async Task<Jogo> Obter(Guid id)
        {
            var jogo = await _db.jogos.FindAsync(id);

            return jogo;
        }

        public void Inserir(Jogo jogo)
        {
            _db.jogos.AddAsync(jogo);
            _db.SaveChanges();
        }

        public async Task Atualizar(Jogo jogo)
        {
            var jogos = await _db.jogos.ToListAsync();
            Jogo jogoToUpdate = jogos.Find(j => j.Nome == jogo.Nome && j.Produtora == jogo.Produtora);
            _db.jogos.Update(jogoToUpdate);
            _db.SaveChanges();

        }

        public async Task Remover(Guid id)
        {
            var jogos = await _db.jogos.ToListAsync();
            Jogo jogo = jogos.Find(j => j.Id == id);

            _db.jogos.Remove(jogo);
            _db.SaveChanges();
        }

    }
}
