using GameTop.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : IJogador
    {
        public string _Nome { get; set; }

        public Jogador1(string nome)
        {
            _Nome = nome;
        }
         public string Chute()
        {
            return $"{_Nome} está chutando \n";
        }
        public string  Corre ()
        {
            return $"{_Nome} está Correndo \n";
        }
        public  string Passe ()
        {
            return $"{_Nome} está passando \n";
        }
    }
}