
Datos DatosCliente = new Datos("Veronica","722107382","calle goya n3","veronikka@gmail.com",1);
Console.WriteLine("Nombre: " + DatosCliente.Nombre);
Console.WriteLine("Telefono:  " + DatosCliente.Telefono);
Console.WriteLine("Direcion: " + DatosCliente.Direcion);
Console.WriteLine("Email: " + DatosCliente.Email);
Console.WriteLine("Cliente: " + Convert.ToString(DatosCliente.IScliente));



public struct Datos 
{

    public Datos(string nombre,string telefono, string direcion, string email, int iscliente)

    {
        Nombre = nombre;
        Telefono = telefono;
        Direcion = direcion;
        Email = email;
        IScliente = iscliente;

    }



public string Nombre  { get; set; }
public string  Telefono { get; set; }
public string Direcion { get; set; }
public string Email { get; set; }
public int IScliente { get; set; }


    public override string ToString() => $"({Nombre},{Telefono},{Direcion},{Email},{IScliente})";



}

