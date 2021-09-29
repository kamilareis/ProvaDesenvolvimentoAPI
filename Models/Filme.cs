using System;

namespace ProvaDesenvolvimentoAPI.Models
{
    public class Filme
    {
        //Construtor
        public Filme() => CriadoEm = DateTime.Now;
        
        //Atributos ou propriedades
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int Ano { get; set; }
        public string Duração { get; set; }
        public DateTime CriadoEm { get; set; }

        //ToString
        public override string ToString() =>
            $"Titulo: { Titulo } | Genero: { Genero } | Ano: { Ano } | Duração: { Duração } | Criado em: { CriadoEm }";
    }
}