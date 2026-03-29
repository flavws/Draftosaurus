using Draft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draftosaurus
{
    public class Partida
    {
        public Int32 id {  get; set; }
        public string face { get; set; }
        public Dictionary<string, string[]> facesDados = new Dictionary<string, string[]>();
        public Dictionary<Int32, Jogador> jogadores = new Dictionary<int, Jogador>();
        public Partida(Int32 id) { 
            this.id = id;
            string[] dadosFaces = Jogo.ListarFacesDado().Replace("\r", "").Trim().Split('\n');
            foreach(var dados in dadosFaces)
            {
                string[] infos = dados.Split(',');
                this.facesDados.Add(infos[0], infos);
            }
        }
        public string[] Verificar()
        {
            string res = Jogo.VerificarPartida(this.id);
            if (res.StartsWith("ERRO"))
                throw new Exception(res);
            string[] dados = res.Trim().Replace("\r", "").Split(',');
            return dados;
        }
        public void loadJogadores()
        {
            string res = Jogo.ListarJogadores(this.id);
            string[] dados = res.Trim().Replace("\r", "").Split('\n');
            if (res.StartsWith("ERRO"))
                throw new Exception(res);
            foreach (var dado in dados)
            {
                string[] jogadorData = dado.Split(',');
                Jogador jogador = new Jogador(Int32.Parse(jogadorData[0]));
                jogador.nome = jogadorData[1];
                jogador.pontuacao = Int32.Parse(jogadorData[2]);

                this.jogadores.Add(jogador.id, jogador);
            }

        }
    }
}
