﻿using Domain;
using Olive;
using Olive.Mvc;

namespace Controllers
{
    public class BaseController : Olive.Mvc.Controller
    {
        public BaseController()
        {
            ApiClient.FallBack.Handle(arg => Notify(arg.FriendlyMessage, false));
        }

        protected override bool IsMicrofrontEnd => true;

        // Here you can add helper methods to all your controllers.
    }
}

namespace ViewComponents
{
    public abstract class ViewComponent : Olive.Mvc.ViewComponent
    {
        // Here you can add helper methods to all your cshtml views.
        string a = "1111";
        string a1 = "1";
        string a1 = "2211";
        string a1 = "21111111111111111";




    }
}