using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InternetShop.Model.EntityModels
{
    internal class FactorMetaData
    {
        [ScaffoldColumn(false)]
        //[Bindable(false)]
        public int ID { get; set; }

        [Required(ErrorMessage = "تاریخ خرید را وارد کنید", AllowEmptyStrings = false)]
        [DisplayName("تاریخ خرید")]
        [Display(Name = "تاریخ خرید")]
        public System.DateTime BuyDate { get; set; }

        [DisplayName("کد رهگیری")]
        [Display(Name = "کد رهگیری")]
        [StringLength(50, ErrorMessage = "این فیلد باید حداکثر 50 کاراکتر باشد")]
        public string FlloweCode { get; set; }

        [DisplayName("توضیحات خرید")]
        [Display(Name = "توضیحات خرید")]
        [StringLength(400, ErrorMessage = "این فیلد باید حداکثر 400 کاراکتر باشد")]
        public string Description { get; set; }

        [DisplayName("خریدار")]
        [Display(Name = "خریدار")]
        [ScaffoldColumn(false)]
        public Nullable<int> UserID { get; set; }

        [DisplayName("قیمت")]
        [Display(Name = "قیمت")]
        [ScaffoldColumn(false)]
        public decimal Price { get; set; }

        [DisplayName("نام خریدار")]
        [Display(Name = "نام خریدار")]
        [Required(ErrorMessage = "نام خود را وارد کنید", AllowEmptyStrings = false)]
        [StringLength(50, ErrorMessage = "این فیلد باید حداکثر 50 کاراکتر باشد")]
        public string Name { get; set; }

        [DisplayName("موبایل خریدار")]
        [Display(Name = "موبایل خریدار")]
        [Required(ErrorMessage = "موبایل خود را وارد کنید", AllowEmptyStrings = false)]
        [StringLength(50, ErrorMessage = "این فیلد باید حداکثر 50 کاراکتر باشد")]
        public string Mobile { get; set; }

        [DisplayName("ایمیل خریدار")]
        [Display(Name = "ایمیل خریدار")]
        [Required(ErrorMessage = "ایمیل خود را وارد کنید", AllowEmptyStrings = false)]
        [StringLength(50, ErrorMessage = "این فیلد باید حداکثر 50 کاراکتر باشد")]
        public string Email { get; set; }

        [DisplayName("آدرس خریدار")]
        [Display(Name = "آدرس خریدار")]
        [Required(ErrorMessage = "آدرس خود را وارد کنید", AllowEmptyStrings = false)]
        [StringLength(200, ErrorMessage = "این فیلد باید حداکثر 200 کاراکتر باشد")]
        public string Address { get; set; }

        [DisplayName("کد پستی خریدار")]
        [Display(Name = "کد پستی خریدار")]
        [StringLength(15, ErrorMessage = "این فیلد باید حداکثر 15 کاراکتر باشد")]
        public string CodePosti { get; set; }

        [DisplayName("خرید نهایی شده است")]
        [Display(Name = "خرید نهایی شده است")]
        [ScaffoldColumn(false)]
        public bool IsFinish { get; set; }
    }

}

namespace InternetShop.Model
{
    [ModelMetadataType(typeof(InternetShop.Model.EntityModels.FactorMetaData))]
    public partial class Factor
    {
    }
}


