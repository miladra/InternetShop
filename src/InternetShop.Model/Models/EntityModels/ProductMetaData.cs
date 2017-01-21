using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InternetShop.Model.EntityModels
{
    internal class ProductMetaData
    {
        [ScaffoldColumn(false)]
        //[Bindable(false)]
        public int ID { get; set; }

        [Required(ErrorMessage = "نام محصول را وارد کنید", AllowEmptyStrings = false)]
        [DisplayName("نام محصول")]
        [Display(Name = "نام محصول")]
        [StringLength(50, ErrorMessage = "این فیلد باید حداکثر 50 کاراکتر باشد")]
        public string Name { get; set; }

       // [AllowHtml]
        [Required(ErrorMessage = "توضیحات محصول را وارد کنید", AllowEmptyStrings = false)]
        [DisplayName("توضیحات محصول")]
        [Display(Name = "توضیحات محصول")]
        [DataType(DataType.Html, ErrorMessage = "فرمت متن نا معتبر است")]
        public string Summery { get; set; }


        [DisplayName("گروه محصول")]
        [Display(Name = "گروه محصول")]
        [ScaffoldColumn(false)]
        public int GroupID { get; set; }

        [Display(Name = "قیمت محصول")]
        [DisplayName("قیمت محصول")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "قیمت محصول را وارد کنید")]
        [Range(1, int.MaxValue, ErrorMessage = "قیمت نا معتبر است")]
        public decimal Price { get; set; }

        [Display(Name = "آدرس محصول")]
        [DisplayName("آدرس محصول")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "آدرس محصول را وارد کنید")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Url, ErrorMessage = "آدرس محصول باید Url معتبر باشد")]
        [StringLength(100, ErrorMessage = "این فیلد باید حداکثر 100 کاراکتر باشد")]
        public string Url { get; set; }

        [DisplayName("تگ کلمات کلیدی")]
        [Display(Name = "تگ کلمات کلیدی")]
        [StringLength(300, ErrorMessage = "این فیلد باید حداکثر 300 کاراکتر باشد")]
        public string Keywords { get; set; }

        [DisplayName("تگ توضیحات")]
        [Display(Name = "تگ توضیحات")]
        [StringLength(500, ErrorMessage = "این فیلد باید حداکثر 500 کاراکتر باشد")]
        public string Description { get; set; }

        [DisplayName("برچسب ها")]
        [Display(Name = "برچسب ها")]
        [StringLength(200, ErrorMessage = "این فیلد باید حداکثر 200 کاراکتر باشد")]
        public string Tags { get; set; }


        [DisplayName("تعداد Like ها")]
        [Display(Name = "تعداد Like ها")]
        [Range(0, int.MaxValue, ErrorMessage = "مقدار نا معتبر است")]
        public int Like { get; set; }


        [DisplayName("تعداد Dislike ها")]
        [Display(Name = "تعداد Dislike ها")]
        [Range(0, int.MaxValue, ErrorMessage = "مقدار نا معتبر است")]
        public int Dislike { get; set; }

        [DisplayName("این محصول فعال است")]
        [Display(Name = "این محصول فعال است")]
        public bool Enabled { get; set; }

        [DisplayName("تصویر محصول")]
        [Display(Name = "تصویر محصول")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.ImageUrl)]
        public string Image { get; set; }

    }
}


namespace InternetShop.Model
{
    [ModelMetadataType(typeof(InternetShop.Model.EntityModels.ProductMetaData))]
    public partial class Product
    {
    }
}
