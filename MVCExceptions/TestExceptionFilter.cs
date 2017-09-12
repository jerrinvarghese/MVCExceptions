using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExceptions
{
    public class TestExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (filterContext.Exception is NullReferenceException)
            {
                filterContext.Result = new RedirectResult("~/Views/Shared/Error.cshtml");
            }
           // throw new NotImplementedException();
        }
    }
}