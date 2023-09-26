using System;

namespace Proyecto.Dominio
{
    public class Establecimiento
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre{ get; set; }
        public string Responsable{ get; set; }
        public string Direccion{ get; set; }
       
    }
}




using System;
using System.Collections.Generic;

namespace Proyecto.Dominio
{
    public class Manzana_Cuidado
    {
        public int Id { get; set; }
        public string Codigo{ get; set; }
        public string Nombre{ get; set; }
        public string Direccion{ get; set; }
        public string Localidad{ get; set; }

   
    }
}








using System;

namespace Proyecto.Dominio
{
    public class Mujer
    {
       
        public int Id { get; set; }
        public string Documento{ get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
         public string Direccion { get; set; }
        public string Ocupacion { get; set; }
        public string Servicio_Participacion { get; set; }
        
    }
}







namespace Proyecto.Dominio
{
    public class Municipio
    {
     
        public int Id { get; set; }
        public int Nombre { get; set; }
        
    }
}



using System;

namespace Proyecto.Dominio
{
    public class Registro_Cuidadora
    {
        public int Id { get; set; }
         public string Manzana { get; set; }
         public string Servicio{ get; set; }
         public DateTime Fecha{ get; set; }
          public DateTime Hora{ get; set; }
    
    }
}





using System;

namespace Proyecto.Dominio
{
    public class Servicio
    {
        public int Id { get; set; }
        public string Codigo{ get; set; }
        public string Nombre{ get; set; }
        public string Descripcion{ get; set; }
    }
}


y este es el appContext:using Microsoft.EntityFrameworkCore;
using Proyecto.Dominio;

namespace Proyecto.Persistencia
{
    public class AppContextS : DbContext
    {
        //Es un objeto que le pertenece al context que me permite modelar la base de datos

        //<Establecimiento> es el nombre de la tabla que tengo en dominio
        //Establecimientos= es el nuevo nombre que va a tener mi tabla en la base de datos

        public DbSet<Establecimiento> Establecimientos {get;set;}
    
        public DbSet<Manzana_Cuidado> Manzana_Cuidados{get;set;}
        public DbSet<Mujer> Mujeres {get;set;}
        public DbSet<Municipio>Municipios {get;set;}
        public DbSet<Registro_Cuidadora> Registro_Cuidadoras {get;set;}
        public DbSet<Servicio> Servicios {get;set;}

    // el void es un metodo vacío que sirve para la conexion a la base de datos.
        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.
                UseSqlServer("Data source=(localdb)\\MSSQLLocalDB; Initial Catalog=AppS");
            }

        }

    }

}
