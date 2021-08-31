using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Smm.Contoh.ServiceApplication.EnumDto
{
    public enum Agama
    {
        Islam = 0,
         [Display(Name = "Kristen Protestan")]
        //[Description("Kristen Protestan")]
        KristenProtestan = 1,
        Katolik = 2,
        Hindu = 3,
        Buddha = 4,
        Konghucu = 5
    }
}
