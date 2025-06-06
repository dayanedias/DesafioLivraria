namespace DesafioLivraria.Communication.Requests;

public class RequestUpdateBookJson
{
    public string Title { get; set; } = String.Empty;
    public string Author { get; set; } = String.Empty;
    public Genero Genero { get; set; }
    public double Price { get; set; }
    public int QtdEstoque { get; set; }
}
