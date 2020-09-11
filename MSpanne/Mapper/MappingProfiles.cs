using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.Models;
using Poulina.MSpanne.Domain.DTO;

namespace Ms_Panne.Mapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {

            CreateMap<Panne, PanneDTO>()
         .ReverseMap();


            CreateMap<Intervention, InterventionDTO>()
         .ForMember(a => a.descriptionPanne, i => i.MapFrom(src => src.Panne.description))
         .ForMember(a => a.TypeInterventionLabel, i => i.MapFrom(src => src.Type_intervention.type_intervention))
         .ReverseMap();

         //   CreateMap<PanneDTO, NbrPanneDTO>()
         //.ReverseMap();




        }
    }
}

