using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ms_Panne.Domain.Poulina.MSpanne.Domain.Command
{
    public class PutGenericCommand<TEntity> : IRequest<string> where TEntity : class
    {
        public TEntity Entity { get; }
        public PutGenericCommand(TEntity entity)
        {
            Entity = entity;
        }

    }
}
