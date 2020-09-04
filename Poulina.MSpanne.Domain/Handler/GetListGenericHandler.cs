using MediatR;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.IRepository;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ms_panne.Domain.Poulina.MSpanne.Domain.Models.Handler
{
    public class GetListGenericHandler<TEntity> : IRequestHandler<GetListGenericQuery<TEntity>, IEnumerable<TEntity>> where TEntity : class
    {

        private readonly IGenericRepository<TEntity> Repository;
        public GetListGenericHandler(IGenericRepository<TEntity> Repository)
        {
            this.Repository = Repository;
        }


        public Task<IEnumerable<TEntity>> Handle(GetListGenericQuery<TEntity> request, CancellationToken cancellationToken)
        {
            var result = Repository.GetListByExpression(request.Condition, request.Includes);
            return Task.FromResult(result);
        }

    }
}
