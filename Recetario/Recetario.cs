using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Recetario
{
   public class Recetario
    {
        public static List<Receta> _recetario {  get; private set;}

        static Recetario()
        {
            var temp = new List<Receta>();
            temp.Add(new Receta()
            {
                Id = 1,
                Nombre = "Cochinita Pibil",
                Precio = (float)120.00
            });

            temp.Add(new Receta()
            {
                Id = 2,
                Nombre = "Sopa de Tortilla",
                Precio = (float)72.00
            });

            temp.Add(new Receta()
            {
                Id = 3,
                Nombre = "Pollo con Mole",
                Precio = (float)150.00
            });
           
            _recetario = temp.OrderBy(i => i.Nombre).ToList();
        }
    }
}