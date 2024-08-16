using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.models;

public class Pessoa(string nome, string sobrenome)
{
    public string Nome { get; set; } = nome;
    public string Sobrenome { get; set; } = sobrenome;
}