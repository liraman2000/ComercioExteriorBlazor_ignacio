namespace ComercioExteriorBlazor.Services
{
    public class IdentityInformation
    {
        public bool IsAuthenticated { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int IdNegocio { get; set; }
        public int IdUsuario { get; set; }
        public string Rol { get; set; }
        public bool consultaInicio { get; set; }
        public bool detalleDash { get; set; }
        public int DashIdNegocio { get; set; }
        public int DashIdPeriodoNegocio { get; set; }


    }
}
