using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploAjaxPartialView.ViewModels
{
    public class DataViewModel
    {
        public int Id { get; set; }

        public string Descricao { get; set; }
        public DateTime DataHora { get; internal set; }
    }
}