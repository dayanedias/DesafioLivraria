using DesafioLivraria.Communication.Requests;

namespace DesafioLivraria.Communication.Responses;

public class ResponseRegisteredBookJson
{
    public int Id { get; set; }

    public string Title { get; set; } = String.Empty;
    public Genero Genero { get; set; }
}
