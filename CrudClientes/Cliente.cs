using System;
using System.Collections.Generic;
using System.Text;

namespace CrudClientes
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int NumeroCasa { get; set; }
        public string Uf { get; set; }

    }
}
