using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace InternetShop.Model.EntityModels
{

    internal class UserMetaData
    {
        [ScaffoldColumn(false)] 
        //[Bindable(false)]
        public int ID { get; set; }

        [Required(ErrorMessage = "نام و نام خانوادگی خود را وارد کنید", AllowEmptyStrings = false)]
        [DisplayName("نام و نام خانوادگی")]
        [Display(Name = "نام خانوادگی")]
        [StringLength(50, ErrorMessage = "این فیلد باید حداکثر 50 کارکتر باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "ایمیل خود را وارد کنید")]
        [Display(Name = "ایمیل (نام کاربری)")]
        [DisplayName("ایمیل (نام کاربری)")]
        [RegularExpression(@"^[_A-Za-z0-9-\+]+(\.[_A-Za-z0-9-]+)*@[A-Za-z0-9-]+(\.[A-Za-z0-9-]+)*(\.[A-Za-z]{2,4})$", ErrorMessage = "ایمیل را بدرستی وارد کنید")]
        [StringLength(50, ErrorMessage = "این فیلد باید حداکثر 50 کاراکتر باشد")]
        public string Username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "رمز عبور خود را وارد کنید")]
        [DisplayName("رمز عبور")]
        [Display(Name = "رمز عبور")]
        [DataType(DataType.Password)]
        public string Password{ get; set; }


        [Display(Name = "تاریخ تولد")]
        [DisplayName("تاریخ تولد")]
        public Nullable<System.DateTime> BirthDate { get; set; }


        [DisplayName("شماره موبایل")]
        [Display(Name = "شماره موبایل")]
        [RegularExpression(@"^0?9[123]\d{8}$", ErrorMessage = "شماره موبایل را بدرستی وارد کنید")]
        [StringLength(50, ErrorMessage = "این فیلد باید حداکثر 50 کاراکتر باشد")]
        public string Mobile { get; set; }

        [Display(Name = "شماره تماس")]
        [DisplayName("شماره تماس")]
        [StringLength(50, ErrorMessage = "این فیلد باید حداکثر 50 کاراکتر باشد")]
        public string Tell { get; set; }


        [DisplayName("جنسیت")]
        [Display(Name = "جنسیت")]
        public Nullable<bool> Gender { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("وضعیت")]
        [Display(Name = "وضعیت")]
        public Nullable<byte> Status { get; set; }
    }
}
namespace InternetShop.Model
{
    [ModelMetadataType(typeof(InternetShop.Model.EntityModels.UserMetaData))]
    public partial class User
    {
        [NotMapped]
        [Required(AllowEmptyStrings = false, ErrorMessage = "رمز عبور خود را تکرار کنید")]
        [DisplayName("تکرار رمز عبور")]
        [Display(Name = "تکرار رمز عبور")]
        [DataType(DataType.Password)]
        [Compare("Password" , ErrorMessage = "تکرار پسورد یکسان نیست")]
        public string ConfirmPassword { get; set; }
    }
}