﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarPessoas
{
    public class Pessoa
    {
        //variáveis globais
        private string nome;
        private string email;
        private string telCel;


        //criando método construtor (ja existe mesmo sem chamar)
        public Pessoa()
        {
        }

        public Pessoa(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }

        public Pessoa(string nome, string email, string telCel)
        {
            this.nome = nome;
            this.email = email;
            this.telCel = telCel;
        }

        //criando os métodos GET e SET da classe
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string TelCel { get => telCel; set => telCel = value; }
    }
}
