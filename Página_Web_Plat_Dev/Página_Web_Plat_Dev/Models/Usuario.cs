namespace Página_Web_Plat_Dev.Models
{
    public class Usuario
    {
        public int id;
        public string usuario;
        public string contraseña;




        public Usuario(int id, string usuario, string contraseña)
        {
            this.id = id;
            this.usuario = usuario;
            this.contraseña = contraseña;
        }
    }
}
