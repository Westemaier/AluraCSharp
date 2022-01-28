namespace ByteBank.Modelos
{
    public class ParceiroComercial : IAutenticavel
    { 
        public string Senha { get; set; }      
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}