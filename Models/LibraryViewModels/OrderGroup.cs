using System;
using System.ComponentModel.DataAnnotations;

namespace ExamenSADE_SupleantuSara.Models.LibraryViewModels
{
    public class OrderGroup
    {
        [DataType(DataType.Date)]
        public DateTime? OrderDate { get; set; }
        public int ProductCount { get; set; }
    }
}
