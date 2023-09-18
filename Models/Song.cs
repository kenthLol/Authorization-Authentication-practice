namespace practica4.Models;

public class Song
{
    public int SongId { get; set; }
    public string? Title { get; set; }
    public TimeSpan Duration { get; set; }
    // Otros campos relacionados con la canción

    public int AlbumId { get; set; } // Clave externa
    public Album? Album { get; set; } // Propiedad de navegación hacia el álbum de la canción
}