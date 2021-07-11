using JogosAPI.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JogosAPI.Repositories
{
    public interface IJogoRepository 
    {
        Task<List<Jogo>> Obter();
        Task<Jogo> Obter(Guid id);
        void Inserir(Jogo jogo);
        Task Atualizar(Jogo jogo);
        Task Remover(Guid id);
    }
}
