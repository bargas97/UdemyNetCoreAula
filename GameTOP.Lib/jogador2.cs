using GameTop.Interface;

namespace GameTOP.Lib
{
    public class jogador2 : IJogador
    {
        public string Chute()
        {
            return "Maradona estas pateando \n";
        }

        public string Corre()
        {
            return "Maradona estas corriendo \n";
        }

        public string Passe()
        {
            return "Maradona estas passando \n";
        }
    }
}