
using System.ComponentModel;

namespace WebApplicationOnline.Entities
{
    public class Mountain
    {
        public int MountainId { get; set; }
        [DisplayName("Nombre de la montaña")]
        public string Nombre { get; set; }
        [DisplayName("Altura en metros")]
        public int Altitud { get; set; }
    }
}
