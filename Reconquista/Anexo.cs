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
    
    public partial class Anexo
    {
        public int ID_anexo { get; set; }
        public byte[] Arquivo_anexo { get; set; }
        public int ID_bem { get; set; }
        public string Nome_Arquivo { get; set; }
        public string Ext_Arquivo { get; set; }
    
        public virtual Bem Bem { get; set; }
    }
}
