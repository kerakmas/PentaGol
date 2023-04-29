using PentaGol.Domain.Commons;
using PentaGol.Domain.Confirgurations;
using PentaGol.Service.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaGol.Service.Extensions
{
    public static class CollectionExtension
    {
        public static IQueryable<TEntity> ToPagedList<TEntity>(this IQueryable<TEntity> entities, PaginationParams @params)
          where TEntity : Auditable
        {
            return @params.PageIndex > 0 && @params.PageSize > 0 ?
                entities.OrderBy(e => e.Id)
                    .Skip((@params.PageIndex - 1) * @params.PageSize).Take(@params.PageSize) :
                        throw new PentaGolException(400, "Please, enter valid numbers");
        }
    }
}
