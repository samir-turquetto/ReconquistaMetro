//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Reconquista
{
    using System;
    using System.Collections.Generic;
    
    public partial class Telefone
    {
        public int ID_tel { get; set; }
        public string Telefone1 { get; set; }
        public string Contato_tel { get; set; }
        public int ID_cli { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}
