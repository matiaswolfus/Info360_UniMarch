

namespace Info360_EFSI.Models;

public class Usuario{
    
    public string Nombre { get; private set; }
     public string Contraseña { get;  set; }
      public string Apellido { get;  set; }
      public string Email { get;  set; }
       public string Username { get;  set; }
      


     public Usuario(string Nombre, string Contraseña, string Apellido, string Email, string Username){
     this.Nombre = Nombre;
     this.Contraseña = Contraseña;
      this.Email = Email;
      this.Apellido = Apellido;
      this.Username = Username;
}
}