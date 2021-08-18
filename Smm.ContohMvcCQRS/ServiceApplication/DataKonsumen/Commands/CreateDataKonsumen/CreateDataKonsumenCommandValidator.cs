using System.Data;
using System.Security;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRS.ServiceApplication.DataKonsumen.Commands.CreateDataKonsumen
{
    public class CreateDataKonsumenCommandValidator: AbstractValidator<CreateDataKonsumenCommand>
    {
        public CreateDataKonsumenCommandValidator()
        {
                

        }
    }
}
