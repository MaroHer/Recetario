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
    [Activity(Label = "DetalleActivity")]
    public class DetalleActivity : Activity
    {
        Android.Support.V7.Widget.Toolbar toolbarR;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Detalle);
            toolbarR = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbarR);
            toolbarR.Title = "Nombre de la receta";
            toolbarR.InflateMenu(Resource.Menu.opciones);
            toolbarR.MenuItemClick += Toolbar_MenuItemClick;
            FindViewById<ImageButton>(Resource.Id.regresar).Click += (sender, e) => Finish();

        }

        private void Toolbar_MenuItemClick(object sender, Android.Support.V7.Widget.Toolbar.MenuItemClickEventArgs e)
        {
            switch (e.Item.ItemId)
            {
                case Resource.Id.opcion1:
                    break;
                case Resource.Id.opcion2:
                    StartActivity(typeof(AcercaActivity));
                    break;

                case Resource.Id.uno: e.Item.SetChecked(true);break;
                case Resource.Id.dos: e.Item.SetChecked(true); break;
                case Resource.Id.trs: e.Item.SetChecked(true); break;

            }
            
        }
    }
}