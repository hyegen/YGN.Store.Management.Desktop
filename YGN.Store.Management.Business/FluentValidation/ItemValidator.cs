using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Entities.Concrete;

namespace YGN.Store.Management.Business.FluentValidation
{
    public class ItemValidator : AbstractValidator<Item>
    {
        public ItemValidator()
        {
            RuleFor(x => x.ItemCode).NotEmpty().WithMessage("Ürün Kodu boş bırakılamaz.");
            RuleFor(x => x.ItemName).NotEmpty().WithMessage("Ürün Adı boş bırakılamaz.");
        }
    }
}
