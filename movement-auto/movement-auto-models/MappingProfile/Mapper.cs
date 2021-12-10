using AutoMapper;
using movement_auto.Extensions;
using movement_auto_dtos;
using movement_auto_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movement_auto_utilities.MappingProfile
{
    public class Mapper : Profile
    {
        // Map Main Domain to API Dto
        public Mapper()
        {
            CreateMap<Image, ImageDto>();
            CreateMap(typeof(QueryResult<>), typeof(QueryResultDto<>));
            CreateMap<AutoMake, AutoMakeDto>();
            CreateMap<AutoMake, KeyValuePairDto>();
            CreateMap<AutoModel, KeyValuePairDto>();
            CreateMap<Feature, KeyValuePairDto>();
            CreateMap<Vehicle, SaveVehicleDto>()
                .ForMember(vr => vr.Contact, opt => opt.MapFrom(v => 
                    new ContactDto { 
                        Name = v.ContactName, 
                        Email = v.ContactEmail, 
                        Phone = v.ContactPhone 
                    }))
              .ForMember(vr => vr.Features, opt => opt.MapFrom(v => v.VehicleFeatures.Select(vf => vf.FeatureId)));
            CreateMap<Vehicle, VehicleDto>()
           .ForMember(vr => vr.AutoMake, opt => opt.MapFrom(v => v.AutoModel.AutoMake))
           .ForMember(vr => vr.Contact, opt => opt.MapFrom(v => 
                   new ContactDto { 
                       Name = v.ContactName, 
                       Email = v.ContactEmail, 
                       Phone = v.ContactPhone
                   }))
           .ForMember(vr => vr.Features, opt => opt.MapFrom(v => v.VehicleFeatures.Select(vf => 
                   new KeyValuePairDto { 
                       Id = vf.Feature.Id, 
                       Name = vf.Feature.Name 
                   })));

            // API Dto to Domain
            CreateMap<VehicleQueryDto, VehicleQuery>();
            CreateMap<SaveVehicleDto, Vehicle>()
              .ForMember(v => v.Id, opt => opt.Ignore())
              .ForMember(v => v.ContactName, opt => opt.MapFrom(vr => vr.Contact.Name))
              .ForMember(v => v.ContactEmail, opt => opt.MapFrom(vr => vr.Contact.Email))
              .ForMember(v => v.ContactPhone, opt => opt.MapFrom(vr => vr.Contact.Phone))
              .ForMember(v => v.VehicleFeatures, opt => opt.Ignore())
              .AfterMap((vr, v) => {
                  // Remove unselected features
                  var removedFeatures = v.VehicleFeatures.Where(f => !vr.Features.Contains(f.FeatureId)).ToList();
                  foreach (var f in removedFeatures)
                      v.VehicleFeatures.Remove(f);

                  // Add new features
                  var addedFeatures = vr.Features.Where(id => !v.VehicleFeatures.Any(f => f.FeatureId == id)).Select(id => new VehicleFeature { FeatureId = id }).ToList();
                  foreach (var f in addedFeatures)
                      v.VehicleFeatures.Add(f);
              });
        }
    }
}
