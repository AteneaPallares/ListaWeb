
using System;
using System.ComponentModel.DataAnnotations;

namespace ListaWeb.Models
{


    public class PendienteItem
    {
        /// Guid genera un secuencia aletoria 
        /// Investigar Guid
        public Guid Id { get; set; }

        public bool EstaHecha { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Pendiente { get; set; }

        public DateTimeOffset? ParaCuando { get; set; }

        /// Aquí deben hacer todo lo necesario para la creación de un Pendiente
        public PendienteItem()
        {
            /// El Id debe generarse a la creación de Guidzz
            DateTime hola=DateTime.Today;
            //Le puse que me sumara 3 porque cuando le ponia 2 me decia que se entregaba mañana
            ParaCuando=hola.AddDays(3);

            /// Las tareas son para dentro de dos días 
            System.Guid  miGUID = System.Guid.NewGuid();
            String Id = miGUID.ToString();
            EstaHecha=false;
            
            /// Siempre las tareas deben estas no EstaHecha = false
           

        }
    }
}