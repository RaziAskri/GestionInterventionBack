using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ms_Panne.Domain.Poulina.MSpanne.Domain.Command
{
    public class PostGenericCommand<TEntity> : IRequest<string> where TEntity : class
    {
        public TEntity Entity { get; }
        public PostGenericCommand(TEntity entity)
        {
            Entity = entity;
        }

    }
}
