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
    public class Receta
    {
        public int Id { get; set;}
        public string Nombre { get; set; }
      
        public float Precio { get; set; } 
        public override string ToString()
        { return Nombre;}
        
            


    }
}