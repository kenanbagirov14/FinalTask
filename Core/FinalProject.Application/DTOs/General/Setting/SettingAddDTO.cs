using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Application.DTOs.General
{
    public class SettingAddDTO : BaseDTO
    {
        public string? SlideImagePath { get; set; }
        public string? SlideImageFullPath { get; set; }
        public string? SlideBigText { get; set; }
        public string? SlideSmallText { get; set; }
        public string? Tittle { get; set; }
        public string? LogoImagePath { get; set; }
        public string? LogoImageFullPath { get; set; }
        public string? Email { get; set; }
        public string? Facebook { get; set; }
        public string? Instagram { get; set; }
        public string? Youtube { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Fax { get; set; }
        public string? AboutText { get; set; }

        public string? WhyUsImagePath { get; set; }
        public string? WhyUsFullImagePath { get; set; }
        public string? WhyUsTittle { get; set; }
        public string? WhyUsText { get; set; }

        public string? WhyUsImagePath1 { get; set; }
        public string? WhyUsFullImagePath1 { get; set; }
        public string? WhyUsTittle1 { get; set; }
        public string? WhyUsText1 { get; set; }

        public string? WhyUsImagePath2 { get; set; }
        public string? WhyUsFullImagePath2 { get; set; }
        public string? WhyUsTittle2 { get; set; }
        public string? WhyUsText2 { get; set; }

        public IFormFile? SlideImage { get; set; }
        public IFormFile? LogoImage { get; set; }
        public IFormFile? WhyUseImage { get; set; }
        public IFormFile? WhyUseImage1 { get; set; }
        public IFormFile? WhyUseImage2 { get; set; }
    }
}
