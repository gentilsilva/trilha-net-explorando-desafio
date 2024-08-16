using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.models;

public class Suite(string tipoSuite, int capacidade, decimal valorDiaria)
{
    public string TipoSuite { get; set; } = tipoSuite;
    public int Capacidade { get; set; } = capacidade;
    public decimal ValorDiaria { get; set; } = valorDiaria;
}
