using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InternetShop.Service;

namespace InternetShop.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly IGroupService groupService;
        private readonly IProductService productService;
        private readonly ICityService cityService;
        private readonly IFactorService factorService;
        private readonly IFactorItemService factorItemService;
        private readonly IUserService userService;
        private readonly IAgencyService agencyService;
        private readonly IRoleService roleService;

        public HomeController(IGroupService groupService,
                              IProductService productService,
                              ICityService cityService,
                              IFactorService factorService,
                              IUserService userService,
                              IFactorItemService factorItemService,
                              IRoleService roleService,
                              IAgencyService agencyService)
        {
            this.groupService = groupService;
            this.productService = productService;
            this.cityService = cityService;
            this.factorService = factorService;
            this.userService = userService;
            this.factorItemService = factorItemService;
            this.agencyService = agencyService;
            this.roleService = roleService;
        }
        public string Index()
        {
            return "Product count is <"+ productService.Count() + ">";
        }
    }
}
