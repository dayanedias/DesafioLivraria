namespace DesafioLivraria.Communication.Requests;

public enum Genero
{
    Ficcao,
    Romance,
    Misterio,
    Policial,
    Drama,
    Comedia
}

public class RequestRegisterBookJson
{
    //public int Id { get; set; }
    public string Title { get; set; } = String.Empty;
    public string Author { get; set; } = String.Empty;
    public Genero Genero { get; set; }
    public double Price { get; set; }
    public int QtdEstoque { get; set; }

}
