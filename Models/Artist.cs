namespace practica4.Models;

public class Artist
{
    public int ArtistId { get; set; }
    public string? Name { get; set; }
    public string? Photo { get; set; }
    // Otros campos relacionados con el artista
    public List<Album> Albums { get; set; }

    public Artist()
    {
        Albums = new List<Album>();
    }
}