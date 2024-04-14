using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Entities.Concrete;

namespace YGN.Store.Management.Business.FluentValidation
{
    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(x => x.ClientCode).NotEmpty().WithMessage("Cari Kodu boş bırakılamaz.");
            RuleFor(x => x.ClientName).NotEmpty().WithMessage("Cari Adı boş bırakılamaz.");
        }
    }
}
