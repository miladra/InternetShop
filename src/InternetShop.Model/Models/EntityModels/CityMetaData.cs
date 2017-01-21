using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InternetShop.Model.EntityModels
{
    internal class CityMetaData
    {
        [ScaffoldColumn(false)]
       // [Bindable(false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "نام شهر را وارد کنید", AllowEmptyStrings = false)]
        [DisplayName("نام شهر")]
        [Display(Name = "نام شهر")]
        [StringLength(50, ErrorMessage = "این فیلد باید حداکثر 50 کاراکتر باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "استان را انتخاب کنید کنید", AllowEmptyStrings = false)]
        [DisplayName("استان")]
        [Display(Name = "استان")]
        [ScaffoldColumn(false)]
        public int OstanId { get; set; }
    }

}

namespace MvcInternetShop.Model
{
    [ModelMetadataType(typeof(InternetShop.Model.EntityModels.CityMetaData))]
    public partial class City
    {
    }
}


