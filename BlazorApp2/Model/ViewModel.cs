using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorApp2.Model
{
    public class ViewModel
    {
        AufgabenContext EF { get; set; }
        public string NeuAufgabe { get; set; }
       
        public List<Aufgabe> Liste { get; set; }
       
       public void AddAufgabe(Aufgabe a)
        {
           

            Liste.Add(a);
            PropertyChanged();
        }
        public event EventHandler PropertyChangedEvent;
      public async void PropertyChanged()
       {
        PropertyChangedEvent?.Invoke(this, EventArgs.Empty);
       }
}
}
