﻿using IK_Project.Domain.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace IK_Project.UI.Areas.Admin.Models.ViewModels.CompanyVM
{
    public class AdminCompanyCreateVM
    {
        //Şirket Ekleme(Ad, Unvan(LTD.Şti.), Mersis No, Vergi No, VergiDairesi, Logo, Telefon, Adres, Email, Çalışan Sayısı, Kuruluş Yılı, Sözleşme Başlangıç Tarihi, Sözleşme Bitiş Tarihi, AktiflikDurumu)
        public string CompanyName { get; set; }
        //public CompanyTitle CompanyTitle { get; set; }
        //public string MersisNo { get; set; }
        public string TaxNo { get; set; }
        //public string TaxAdministration { get; set; }
        //public FormFile? Logo { get; set; }
        //[NotMapped]
        //[Display(Name = "Logo")]
        //[AllowedExtensions(new string[] { ".jpg", ".png", ".jpeg" })]
        //public IFormFile LogoFile { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int NumberOfEmployees { get; set; }
        //public DateTime Founded { get; set; }
        public DateTime DealStartDate { get; set; } 
        public DateTime? DealEndDate { get; set; }
        public DateTime CreatedDate { get; set; }

        public Status Status { get; set; } = Status.Created;
        public Guid MenuId { get; set; }

        public SelectList? MenuList { get; set; }
        public bool IsActive { get; set; }
    
        public IFormFile? LogoFile { get; set; } 


    }
}
