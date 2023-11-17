using FinalProject.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain.Entities.General
{
    public class Setting : Entity
    {
        public string? SlideImagePath { get; set; }
        public string? SlideImageFullPath { get; set; }
        public string? SlideBigText { get; set; }
        public string? SlideSmallText { get; set; }
        public string? Tittle { get;set; }
        public string? LogoImagePath { get; set; }
        public string? LogoImageFullPath { get; set; }
        public string? Email {  get; set; }
        public string? Facebook { get; set; }
        public string? Instagram { get; set; }
        public string? Youtube { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Fax { get; set; }
        public string? AboutText { get; set; }
        public string? AboutTittle { get; set; }
        public string? AboutImagePath { get; set; }
        public string? AboutFullImagePath { get; set; }

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


    }
}
