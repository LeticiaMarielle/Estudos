using Application.Dominio;
using NUnit.Framework;

[TestFixture]
public class ProfessorTeste {

    Professor professor;

    public ProfessorTeste()
    {
        professor = new Professor();
        professor.Nome = "Flavio";
        professor.CPF = "111.111.111-11";
        professor.Endereco.Bairro = "Centro";
        professor.Endereco.CEP = "35680-277";
        professor.Endereco.Cidade = "Divinopolis";
        professor.Endereco.Estado = "MG";
        professor.Endereco.Numero = "1";
        professor.Endereco.Rua = "Salinas";
        professor.Registro = "123456";
        professor.Formacao = "Engenheiro da Computação";
    }

    [Test]
    public void TestarSeProfessorValido() {
        Assert.NotNull(professor.Registro);
        Assert.NotNull(professor.Formacao);
    }

    [Test]
    public void TestarSeProfessorInvalido() {
        professor.Registro = "";
        Assert.IsEmpty(professor.Registro);  /*IsEmpty usado para string*/
    }

}