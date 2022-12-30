namespace AutoMapperAPI.Models;

public class FuncionarioModel
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public SexoModel Sexo { get; set; }
    public EnderecoModel Endereco { get; set; }
    public decimal Salario { get; set; }
}
