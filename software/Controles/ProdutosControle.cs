
using Modelos;

namespace Controles;

public class ProdutosControle : BaseControle
{
  //----------------------------------------------------------------------------

  public ProdutosControle() : base()
  {
    NomeDaTabela = "Produtos";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idProdutos)
  {
    var collection = liteDB.GetCollection<Produtos>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idProdutos);
  }

  //----------------------------------------------------------------------------

  public virtual List<Produtos>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Produtos>(NomeDaTabela);
    return new List<Produtos>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idProdutos)
  {
    var collection = liteDB.GetCollection<Produtos>(NomeDaTabela);
    collection.Delete(idProdutos);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Produtos produtos)
  {
    var collection = liteDB.GetCollection<Produtos>(NomeDaTabela);
    collection.Upsert(produtos);
  }

  //----------------------------------------------------------------------------
}

internal class Produtos
{
    public object Nome { get; internal set; }
}

s