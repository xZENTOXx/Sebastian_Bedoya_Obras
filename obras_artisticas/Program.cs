// See https://aka.ms/new-console-template for more information
public class Autor
{
    public int idAutor = 0;
    public String? Nombre = "";
    public String? Nacionalidad = "";
    public int Edad = 0;
}

public class Obra
{
    public int idObra = 0;
    public int idAutor = 0;
    public String? Nombre = "";
    public String? Tipo = "";
    public int Año = 0;

}

public class Manga : Obra
{
    public String? Editorial = "";
    public String? Genero = "";
}

public class Pintura : Obra
{
    public String? Estilo = "";
    public String? Materiales = "";
}

public class Programa
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Autores y Obras Artisticas");
        Autor autor1 = new Autor();
        autor1.idAutor = 1;
        autor1.Nombre = "Sebastian";
        autor1.Nacionalidad = "Colombiano";
        autor1.Edad = 18;
        List<Manga> mangas = new List<Manga>();

        mangas.Add(new Manga() { idObra = 1, idAutor = 1, Nombre = "One Piece", Tipo = "Manga", Año = 1997, Editorial = "Shueisha", Genero = "Aventura" });
        mangas.Add(new Manga() { idObra = 2, idAutor = 1, Nombre = "Look Raider", Tipo = "Manga", Año = 2009, Editorial = "Carruius", Genero = "Romance" });

        Autor autor2 = new Autor();
        autor2.idAutor = 2;
        autor2.Nombre = "Camilo";
        autor2.Nacionalidad = "Colombiano";
        autor2.Edad = 40;
        List<Pintura> pinturas = new List<Pintura>();
        pinturas.Add(new Pintura() { idObra = 3, idAutor = 2, Nombre = "La Mona Lisa", Tipo = "Pintura", Año = 1503, Estilo = "Renacimiento", Materiales = "Óleo sobre tabla de álamo" });
        pinturas.Add(new Pintura() { idObra = 4, idAutor = 2, Nombre = "Noche estrellada", Tipo = "Pintura", Año = 2003, Estilo = "Cubismo", Materiales = "Lápiz, pincel y tinta" });
        Console.WriteLine("Autor 1: " + autor1.Nombre);
        Console.WriteLine("Nacionalidad: " + autor1.Nacionalidad);
        Console.WriteLine("Edad: " + autor1.Edad);
        Console.WriteLine("Mangas:");
        foreach (var manga in mangas)
        {
            Console.WriteLine(" - " + manga.Nombre + " (" + manga.Año + "), Editorial: " + manga.Editorial + ", Género: " + manga.Genero);
        }
        Console.WriteLine("Pinturas:");
        Console.WriteLine("Autor 2: " + autor2.Nombre);
        Console.WriteLine("Nacionalidad: " + autor2.Nacionalidad);
        Console.WriteLine("Edad: " + autor2.Edad);
        foreach (var pintura in pinturas)
        {
            Console.WriteLine(" - " + pintura.Nombre + " (" + pintura.Año + "), Estilo: " + pintura.Estilo + ", Materiales: " + pintura.Materiales);
        }
    }
}
