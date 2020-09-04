using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.Command;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.Handler;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.IRepository;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.Models;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.Queries;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.Data;
using System;
using System.Collections.Generic;
using Poulina.ProjectManagmentMS.Data.Repository;
using Ms_panne.Domain.Poulina.MSpanne.Domain.Models.Handler;
using Poulina.MSpanne.Data.Repository;

namespace Poulina.ProjectManagmentMs.Infra
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<PoulinaDbContext>();


            #region Panne

            //Queries
            services.AddTransient<IGenericRepository<Panne>, GenericRepository<Panne>>();
            services.AddTransient<IRequestHandler<GetListGenericQuery<Panne>, IEnumerable<Panne>>, GetListGenericHandler<Panne>>();
            services.AddTransient<IRequestHandler<GetByIdGenericQuery<Panne>, Panne>, GetByIdGenericHandler<Panne>>();


            //Commands
            services.AddTransient<IRequestHandler<PostGenericCommand<Panne>, string>, PostGenericHandler<Panne>>();
            services.AddTransient<IRequestHandler<PutGenericCommand<Panne>, string>, PutGenericHandler<Panne>>();
            services.AddTransient<IRequestHandler<RemoveGenericCommand<Panne>, string>, RemoveGenericHandler<Panne>>();


            #endregion
            #region Type_panne

            //Queries
            services.AddTransient<IGenericRepository<Type_panne>, GenericRepository<Type_panne>>();
            services.AddTransient<IRequestHandler<GetListGenericQuery<Type_panne>, IEnumerable<Type_panne>>, GetListGenericHandler<Type_panne>>();
            services.AddTransient<IRequestHandler<GetByIdGenericQuery<Type_panne>, Type_panne>, GetByIdGenericHandler<Type_panne>>();


            //Commands
            services.AddTransient<IRequestHandler<PostGenericCommand<Type_panne>, string>, PostGenericHandler<Type_panne>>();
            services.AddTransient<IRequestHandler<PutGenericCommand<Type_panne>, string>, PutGenericHandler<Type_panne>>();
            services.AddTransient<IRequestHandler<RemoveGenericCommand<Type_panne>, string>, RemoveGenericHandler<Type_panne>>();





            #endregion
            #region Intervention

            //Queries
            services.AddTransient<IGenericRepository<Intervention>, GenericRepository<Intervention>>();
            services.AddTransient<IRequestHandler<GetListGenericQuery<Intervention>, IEnumerable<Intervention>>, GetListGenericHandler<Intervention>>();
            services.AddTransient<IRequestHandler<GetByIdGenericQuery<Intervention>, Intervention>, GetByIdGenericHandler<Intervention>>();


            //Commands
            services.AddTransient<IRequestHandler<PostGenericCommand<Intervention>, string>, PostGenericHandler<Intervention>>();
            services.AddTransient<IRequestHandler<PutGenericCommand<Intervention>, string>, PutGenericHandler<Intervention>>();
            services.AddTransient<IRequestHandler<RemoveGenericCommand<Intervention>, string>, RemoveGenericHandler<Intervention>>();





            #endregion
            #region Type_intervention

            //Queries
            services.AddTransient<IGenericRepository<Type_intervention>, GenericRepository<Type_intervention>>();
            services.AddTransient<IRequestHandler<GetListGenericQuery<Type_intervention>, IEnumerable<Type_intervention>>, GetListGenericHandler<Type_intervention>>();
            services.AddTransient<IRequestHandler<GetByIdGenericQuery<Type_intervention>, Type_intervention>, GetByIdGenericHandler<Type_intervention>>();


            //Commands
            services.AddTransient<IRequestHandler<PostGenericCommand<Type_intervention>, string>, PostGenericHandler<Type_intervention>>();
            services.AddTransient<IRequestHandler<PutGenericCommand<Type_intervention>, string>, PutGenericHandler<Type_intervention>>();
            services.AddTransient<IRequestHandler<RemoveGenericCommand<Type_intervention>, string>, RemoveGenericHandler<Type_intervention>>();










            #endregion
            #region Interne

            //Queries
            services.AddTransient<IGenericRepository<Interne>, GenericRepository<Interne>>();
            services.AddTransient<IRequestHandler<GetListGenericQuery<Interne>, IEnumerable<Interne>>, GetListGenericHandler<Interne>>();
            services.AddTransient<IRequestHandler<GetByIdGenericQuery<Interne>, Interne>, GetByIdGenericHandler<Interne>>();


            //Commands
            services.AddTransient<IRequestHandler<PostGenericCommand<Interne>, string>, PostGenericHandler<Interne>>();
            services.AddTransient<IRequestHandler<PutGenericCommand<Interne>, string>, PutGenericHandler<Interne>>();
            services.AddTransient<IRequestHandler<RemoveGenericCommand<Interne>, string>, RemoveGenericHandler<Interne>>();


            #endregion
            #region Externe

            //Queries
            services.AddTransient<IGenericRepository<Externe>, GenericRepository<Externe>>();
            services.AddTransient<IRequestHandler<GetListGenericQuery<Externe>, IEnumerable<Externe>>, GetListGenericHandler<Externe>>();
            services.AddTransient<IRequestHandler<GetByIdGenericQuery<Externe>, Externe>, GetByIdGenericHandler<Externe>>();


            //Commands
            services.AddTransient<IRequestHandler<PostGenericCommand<Externe>, string>, PostGenericHandler<Externe>>();
            services.AddTransient<IRequestHandler<PutGenericCommand<Externe>, string>, PutGenericHandler<Externe>>();
            services.AddTransient<IRequestHandler<RemoveGenericCommand<Externe>, string>, RemoveGenericHandler<Externe>>();


            #endregion

            services.AddTransient<MachineRepository>();
        }
    }
}
