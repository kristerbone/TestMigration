﻿namespace SFA.Apprenticeships.Web.Common.Controllers
{
    using System.Web.Mvc;
    using Attributes;
    using Providers;

    [AuthenticateUser]
    public abstract class SfaControllerBase : Controller
    {
        protected SfaControllerBase(ISessionStateProvider session, IUserServiceProvider userServiceProvider)
        {
            Session = session;
            UserServiceProvider = userServiceProvider;
        }

        protected new ISessionStateProvider Session { get; private set; }

        protected IUserServiceProvider UserServiceProvider { get; private set; }

        protected UserContext UserContext { get; private set; }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            UserContext = UserServiceProvider.GetUserContext(filterContext.HttpContext);
            base.OnActionExecuting(filterContext);
        }
    }
}
