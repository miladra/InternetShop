using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InternetShop.Model.EntityModels
{
    internal class RoleMetaData
    {
        [ScaffoldColumn(false)]
        //[Bindable(false)]
        public int ID { get; set; }


        [Required(ErrorMessage = "نقش را وارد کنید", AllowEmptyStrings = false)]
        [DisplayName("نقش")]
        [Display(Name = "نقش")]
        public string Name { get; set; }
    }
}

namespace InternetShop.Model
{
    [ModelMetadataType(typeof(InternetShop.Model.EntityModels.RoleMetaData))]
    public partial class Role
    {

    }
}
