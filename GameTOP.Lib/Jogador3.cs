using GameTop.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : IJogador
    {
        public string Chute()
        {
            return "teste Chutando";
        }

        public string Corre()
        {
            return "teste Correndo";
        }

        public string Passe()
        {
            return "teste Passando";
        }
    }
}