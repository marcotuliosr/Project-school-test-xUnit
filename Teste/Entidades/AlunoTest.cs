using System.Collections.Generic;
using Escola.Entidades;
using Xunit;

namespace Teste;

public class AlunoTest
{
    private Aluno alunoFake()
    {
        return new Aluno()
        {
            Id = 0,
            Nome = "teste",
            Matricula = "0012",
            Notas = new List<double>() { 7, 8, 9 },
            Cpf = "123456789",
        };
    }

    [Fact]
    public void ValidandoInstancia()
    {
        var aluno = alunoFake();

        Assert.Equal(0, aluno.Id);
        Assert.Equal("teste", aluno.Nome);
        Assert.Equal("0012", aluno.Matricula);
        Assert.NotNull(aluno.Notas);
        Assert.Equal("123456789", aluno.Cpf);
    }

    [Fact]
    public void ValidarMedia()
    {

        Assert.Equal(8, alunoFake().Media());

    }

    [Fact]
    public void ValidarSituacao()
    {
        Assert.Equal("aprovado", alunoFake().Situacao().ToLower());
    }

    [Fact]
    public void ValidarNotaFormatada()
    {
        Assert.Equal("7,8,9", alunoFake().NotasFormadata());
    }
}
