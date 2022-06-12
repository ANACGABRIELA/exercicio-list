using System.Text;
using System.Threading.Tasks;
public class Cliente
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Endereco { get; set; }
    public Cliente (string nome, string cpf, string endereco)
    {
        this.Nome = nome;
        this.CPF = cpf;
        this.Endereco = endereco;
    }

}
public class Vendedor
{
    public string Nome { get; set; }
    public string CodigoCracha { get; set; }
    public Vendedor (string nome, string codigoCracha)
    {
        this.Nome = nome;
        this.CodigoCracha = codigoCracha;
    }
}
public class Produto
{
    public string Descricao { get; set; }
    public string Marca { get; set; }
    public double Preco { get; set; }
    public List<string> Produtos;
    public Produto (string descricao, string marca, double preco)
    {
        this.Descricao = descricao;
        this.Marca = marca;
        this.Preco = preco;
        Produtos = new List<string>();
    } 
}
public class CarrinhoCompras
{
    public Cliente cliente;
    List<string> Produtos = new List<string>();
    public CarrinhoCompras()
    {
        Cliente cliente;
        Produtos = new List<string>();
    }
}
public class Venda
{
    public bool Finalizada = true;
    public Vendedor vendedor { get; set; }
    public Cliente clinete { get; set; }
    public double ValorTotal {get;set;}
    List<string> Produtos = new List<string>();
    public Venda(bool Finalizada, Vendedor vendedor, Cliente cliente, double valorTotal )
    {
        this.Finalizada = Finalizada;
        this.ValorTotal = valorTotal;
    }
}
