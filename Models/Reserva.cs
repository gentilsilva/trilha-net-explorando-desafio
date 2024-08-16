using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.models;

public class Reserva(int diasReservados)
{
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; } = diasReservados;

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (this.Suite.Capacidade >= hospedes.Count)
        {
            this.Hospedes = hospedes;
        }
        else
        {
            throw new Exception("Capacidade da Suite excedida.");
        }
    }

    public void CadastrarSuite(Suite suite)
    {
        this.Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        return this.Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
        decimal result = this.DiasReservados * this.Suite.ValorDiaria;

        if (this.DiasReservados >= 10)
        {
            result -= result * 0.10M;
        }
        return result;
    }
}
