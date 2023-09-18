namespace practica4.Models;

public class Album
{
    public int AlbumId { get; set; }
    public string? Title { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string? Portrait { get; set; }
    // Otros campos relacionados con el álbum

    public int ArtistId { get; set; } // Clave externa
    public Artist? Artist { get; set; } // Propiedad de navegación hacia el artista del álbum
    public List<Song> Songs { get; set; }

    public Album()
    {
        Songs = new List<Song>();
    }
}