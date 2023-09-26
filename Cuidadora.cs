using System;
using System.Collections.Generic;

namespace MujerM.Dominio 
{
    public class Cuidadora: Persona
    {
        public string Codigo {get;set;}
        public List <Manzanas> Manzanas {get;set;}
        
    }
}