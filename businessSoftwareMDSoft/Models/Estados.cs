//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace businessSoftwareMDSoft.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estados
    {
        public int Id { get; set; }
        public string Tabla { get; set; }
        public Nullable<short> Estado { get; set; }
        public string Descripcion { get; set; }
        public Nullable<short> Editar { get; set; }
        public Nullable<short> Anular { get; set; }
        public Nullable<short> Imprimir { get; set; }
        public Nullable<short> EnviarHistoricos { get; set; }
        public Nullable<short> Tracking { get; set; }
        public Nullable<short> Visualizar { get; set; }
    }
}
