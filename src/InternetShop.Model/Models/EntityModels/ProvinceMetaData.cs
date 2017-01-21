using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InternetShop.Model.EntityModels
{
    internal class ProvinceMetaData
    {
        [ScaffoldColumn(false)]
       // [Bindable(false)]
        public int ID { get; set; }

        [Required(ErrorMessage = "نام استان را وارد کنید", AllowEmptyStrings = false)]
        [DisplayName("نام استان")]
        [Display(Name = "نام استان")]
        [StringLength(50, ErrorMessage = "این فیلد باید حداکثر 50 کاراکتر باشد")]
        public string Name { get; set; }
    }

}

namespace MvcInternetShop.Model
{
    [ModelMetadataType(typeof(InternetShop.Model.EntityModels.ProvinceMetaData))]
    public partial class Province
    {
    }
}


