using Draft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draftosaurus
{
    public class Jogador
    {
        public Int32 id { get; set; }
        public string senha { get; set; }
        public string nome { get; set; }
        public Int32 pontuacao { get; set; }
        public Jogador(Int32 id, string senha = null) { 
            this.id = id;
            this.senha = senha;
        }
        public string[] ExibirMao()
        {
            string res = Jogo.ExibirMao(this.id, this.senha);
            if(res.StartsWith("ERRO"))
                throw new Exception(res);

            string[] maos = res.Trim().Replace("\r", "").ToUpper().Split('\n');
            return maos;
        }
        public string Jogar(string dinossauro, string cercado)
        {
            string res = Jogo.Jogar(this.id, this.senha, dinossauro, cercado);
            if (res.StartsWith("ERRO"))
                throw new Exception(res);
            return res;
        }




    }
}


