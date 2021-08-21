using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohCQRSNoEventSourcing.ServiceApplication.DataKonsumen.Commands.CreateDataKonsumen
{
    public class CreateDataKonsumenCommandValidator : AbstractValidator<CreateDataKonsumenCommand>
    {
        public CreateDataKonsumenCommandValidator()
        {


        }
    }
}
