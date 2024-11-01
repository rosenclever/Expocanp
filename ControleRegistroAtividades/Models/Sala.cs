namespace ControleRegistroAtividades.Models
{
    public class Sala
    {
        private string _identificacao;
        private int _capacidade;
        public int Id { get; set; }
        public string Identificacao { get { return _identificacao; }
            set { _identificacao = value; } }
        public int Capacidade { get { return _capacidade; }
            set { _capacidade = value; } }
    }
}
