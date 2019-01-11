using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstabCadastros.Dominio.Entidades
{
    public class EntidadeCategorias
    {
        public int Id { get; set; }
        public string NomeCategoria { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataDeCadastro { get; set; }
    }
}
