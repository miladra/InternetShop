using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace InternetShop.Model.EntityModels
{
    internal class AgencyMetaData
    {
        [ScaffoldColumn(false)]
        //[Bindable(false)]
        public int ID { get; set; }

        [Required(ErrorMessage = "نام نمایندگی را وارد کنید", AllowEmptyStrings = false)]
        [DisplayName("نام نمایندگی")]
        [Display(Name = "نام نمایندگی")]
        [StringLength(50, ErrorMessage = "این فیلد باید حداکثر 50 کاراکتر باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "استان را انتخاب کنید کنید", AllowEmptyStrings = false)]
        [DisplayName("استان")]
        [Display(Name = "استان")]
        [ScaffoldColumn(false)]
        public int ProvinceID { get; set; }

        [DisplayName("شهر")]
        [Display(Name = "شهر")]
        [ScaffoldColumn(false)]
        public int CityID { get; set; }

        [DisplayName("آدرس نمایندگی")]
        [Display(Name = "آدرس نمایندگی")]
        [DataType(DataType.MultilineText)]
        [StringLength(500, ErrorMessage = "این فیلد باید حداکثر 500 کاراکتر باشد")]
        public string Address { get; set; }
    }

}

namespace InternetShop.Model
{
    [ModelMetadataType(typeof(InternetShop.Model.EntityModels.AgencyMetaData))]
    public partial class Agency
    {
    }
}


