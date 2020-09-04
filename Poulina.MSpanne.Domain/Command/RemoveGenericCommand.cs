using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ms_Panne.Domain.Poulina.MSpanne.Domain.Command
{
    public class RemoveGenericCommand<TEntity> : IRequest<string> where TEntity : class
    {
        public Guid id;

        public TEntity Entity { get; }
        public RemoveGenericCommand(TEntity entity)
        {
            Entity = entity;
        }

        public RemoveGenericCommand(Guid id)
        {
            this.id = id;
        }
    }
}
