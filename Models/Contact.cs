using System;

namespace BlazorApp4.Models
{
    [Serializable]
    public class Contact
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Email { get; set; }
    }
}
