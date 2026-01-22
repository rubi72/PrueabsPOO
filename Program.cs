namespace PrueabsPOO;

class Persona
{
  private string _nombre;

  public string Nombre
  {
    get => _nombre.ToLower();
    set => _nombre = (value == null) ? "Anónimo" : value;
  }
  public Persona(string nombre = "Anónimo")
  {
  //  Nombre = nombre;    // -> Pasa por la propiedad, está controlado
      _nombre = nombre;   // -> Pasa por el campo (_), no está controlado, tira Excepción
  }
}
class Program
{
    static void Main(string[] args)
    {
        var pepe = new Persona();
        pepe.Nombre = "pepe";
        Console.WriteLine(pepe.Nombre);
    }
}
