public class Piercing{
    public int IdPiercing; 
    public int Precio;
    public string Material;
    public string Color;
    public string Foto;
    public string Nombre;
    public int Likes;

    public Piercing(){}

    public Piercing(int idPiercing, int precio, string material, string color, string foto, string nombre, int likes){
        IdPiercing=idPiercing;
        Precio=precio;
        Material=material;
        Color=color;
        Foto=foto;
        Nombre = nombre;
        Likes = likes;
    }
}