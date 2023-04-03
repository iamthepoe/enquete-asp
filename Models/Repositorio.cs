using System.Collections.Generic;

namespace enquete_asp.Models
{
    public static class Repositorio
    {
        private static List<RespostaModel> respostas = new List<RespostaModel>();
        public static IEnumerable<RespostaModel> Respostas { get { return respostas; } }

        public static void AdicionarResposta(RespostaModel resposta)
        {
            respostas.Add(resposta);
        }
    }
}