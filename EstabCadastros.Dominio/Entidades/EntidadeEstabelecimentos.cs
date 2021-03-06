﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstabCadastros.Dominio.Entidades
{
    public class EntidadeEstabelecimentos
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Agencia { get; set; }
        public string ContaBancaria { get; set; }
        public int IdCategorias { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataDeCadastro { get; set; }
        public virtual EntidadeCategorias Categoria { get; set; }
    }

}