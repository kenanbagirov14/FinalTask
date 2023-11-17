using AutoMapper;
using FinalProject.Application.DTOs.General;
using FinalProject.Application.DTOs.General;
using FinalProject.Application.DTOs.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Teacher, TeacherViewDTO>().ReverseMap();
            CreateMap<Teacher, TeacherAddDTO>().ReverseMap();
            CreateMap<Teacher, TeacherUpdateDTO>().ReverseMap();

            CreateMap<Group, GroupViewDTO>().ReverseMap();
            CreateMap<Group, GroupAddDTO>().ReverseMap();
            CreateMap<Group, GroupUpdateDTO>().ReverseMap();

            CreateMap<Student, StudentViewDTO>().ReverseMap();
            CreateMap<Student, StudentAddDTO>().ReverseMap();
            CreateMap<Student, StudentUpdateDTO>().ReverseMap();

            CreateMap<Message, MessageViewDTO>().ReverseMap();
            CreateMap<Message, MessageAddDTO>().ReverseMap();
            CreateMap<Message, MessageUpdateDTO>().ReverseMap();

            CreateMap<User, UserViewDTO>().ReverseMap();
            CreateMap<User, UserAddDTO>().ReverseMap();
            CreateMap<User, UserUpdateDTO>().ReverseMap();

            CreateMap<Role, RoleViewDTO>().ReverseMap();
            CreateMap<Role, RoleAddDTO>().ReverseMap();
            CreateMap<Role, RoleUpdateDTO>().ReverseMap();

            CreateMap<Setting, SettingAddDTO>().ReverseMap();

        }
    }
}
