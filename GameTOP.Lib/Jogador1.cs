namespace GameTop.Lib
{
    public class Jogador1 : iJogador
    {
        // atalho = prop
        public readonly string _Nome;
        
        //construtor
        public Jogador1(string nome = "Daniel")
        {
            _Nome = nome;  
        }

        // atalho = ctor
        public string Chuta()
        {
            return $"{_Nome} está Chutando \n";
        }

        public string Corre()
        {
            return $"{_Nome} está Correndo \n";            
        }

        public string Passe()
        {
           return $"{_Nome} está Passando \n";    
        }
        
    }
}