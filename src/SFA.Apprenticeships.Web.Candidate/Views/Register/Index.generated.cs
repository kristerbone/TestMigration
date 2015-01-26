﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SFA.Apprenticeships.Web.Candidate.Views.Register
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using SFA.Apprenticeships.Web.Candidate;
    using SFA.Apprenticeships.Web.Candidate.Constants;
    using SFA.Apprenticeships.Web.Candidate.Constants.ViewModels;
    using SFA.Apprenticeships.Web.Candidate.Helpers;
    using SFA.Apprenticeships.Web.Candidate.ViewModels;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Candidate;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Locations;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Login;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.Register;
    using SFA.Apprenticeships.Web.Candidate.ViewModels.VacancySearch;
    using SFA.Apprenticeships.Web.Common.Constants;
    using SFA.Apprenticeships.Web.Common.Framework;
    using SFA.Apprenticeships.Web.Common.Models.Common;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Register/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<RegisterViewModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Register\Index.cshtml"
  
    ViewBag.Title = "Apprenticeships - Create an account";
    Layout = "~/Views/Shared/_ApprenticeshipLayout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">Create an account</h1>\r\n\r\n");

            
            #line 10 "..\..\Views\Register\Index.cshtml"
 using (Html.BeginForm("Index", "Register", FormMethod.Post))
{
    
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Register\Index.cshtml"
Write(Html.Partial("ValidationSummary", ViewData.ModelState));

            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Register\Index.cshtml"
                                                           
    
    //Hidden password input to disable autocomplete

            
            #line default
            #line hidden
WriteLiteral("    <input");

WriteLiteral(" title=\"Hidden password field\"");

WriteLiteral(" type=\"password\"");

WriteLiteral(" class=\"alwayshidden\"");

WriteLiteral(" />\r\n");

            
            #line 16 "..\..\Views\Register\Index.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    <fieldset");

WriteLiteral(" class=\"fieldset-with-border\"");

WriteLiteral(">\r\n        <legend");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Your details</legend>\r\n");

WriteLiteral("        ");

            
            #line 19 "..\..\Views\Register\Index.cshtml"
   Write(Html.FormTextFor(m => m.Firstname, containerHtmlAttributes: new { @class = "form-group-compound" }, controlHtmlAttributes: new { type = "text", autocorrect = "off" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 20 "..\..\Views\Register\Index.cshtml"
   Write(Html.FormTextFor(m => m.Lastname, controlHtmlAttributes: new { type = "text", autocorrect = "off" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 21 "..\..\Views\Register\Index.cshtml"
   Write(Html.EditorFor(r => r.DateOfBirth));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </fieldset>\r\n");

            
            #line 23 "..\..\Views\Register\Index.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    <fieldset");

WriteLiteral(" class=\"fieldset-with-border\"");

WriteLiteral(">\r\n        <legend");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Contact details</legend>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n\r\n");

WriteLiteral("            ");

            
            #line 28 "..\..\Views\Register\Index.cshtml"
       Write(Html.EditorFor(a => a.Address, new { AnalyticsDSCUri = "/register/findaddress" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 29 "..\..\Views\Register\Index.cshtml"
       Write(Html.FormTextFor(m => m.EmailAddress, controlHtmlAttributes: new { @class = "linked-input-master", type = "email", spellcheck = "false" }, hintHtmlAttributes: new { @class = "text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" aria-live=\"polite\"");

WriteLiteral(" id=\"email-available-message\"");

WriteLiteral(" class=\"validation-message\"");

WriteLiteral("></span>\r\n\r\n");

WriteLiteral("            ");

            
            #line 32 "..\..\Views\Register\Index.cshtml"
       Write(Html.FormTextFor(m => m.PhoneNumber, controlHtmlAttributes: new { @class = "form-control-1-3", type = "tel" }, hintHtmlAttributes: new { @class = "text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        </div>\r\n    </fieldset>\r\n");

            
            #line 36 "..\..\Views\Register\Index.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    <fieldset");

WriteLiteral(" class=\"fieldset-with-border\"");

WriteLiteral(">\r\n        <legend");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Sign in details</legend>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <p");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Email address</p>\r\n            <span");

WriteLiteral(" class=\"form-prepopped hidden linked-input-slave\"");

WriteLiteral("></span>\r\n            <label");

WriteLiteral(" class=\"alwayshidden\"");

WriteLiteral(" for=\"hiddenUsername\"");

WriteLiteral("></label>\r\n            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-prepopped alwayshidden linked-input-slave\"");

WriteLiteral(" name=\"username\"");

WriteLiteral(" id=\"hiddenUsername\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" class=\"inl-block inpage-focus\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2201), Tuple.Create("\"", 2241)
, Tuple.Create(Tuple.Create("", 2208), Tuple.Create("#", 2208), true)
            
            #line 44 "..\..\Views\Register\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2209), Tuple.Create<System.Object, System.Int32>(Html.IdFor(m => m.EmailAddress)
            
            #line default
            #line hidden
, 2209), false)
);

WriteLiteral(">Edit your email</a>\r\n        </div>\r\n        \r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 48 "..\..\Views\Register\Index.cshtml"
       Write(Html.FormPasswordFor(m => m.Password, containerHtmlAttributes: new { @class = "form-group-compound" }, hintHtmlAttributes: new { id = "passwordHint" }, controlHtmlAttributes: new { aria_describedby = "passwordHint" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <p");

WriteLiteral(" class=\"form-hint strength-indicator hide-nojs\"");

WriteLiteral(">Password strength: <span");

WriteLiteral(" id=\"pass_meter\"");

WriteLiteral(" class=\"\"");

WriteLiteral("></span></p>\r\n        </div>\r\n        \r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 53 "..\..\Views\Register\Index.cshtml"
       Write(Html.FormPasswordFor(m => m.ConfirmPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </fieldset>\r\n");

            
            #line 56 "..\..\Views\Register\Index.cshtml"

    
            
            #line default
            #line hidden
            
            #line 57 "..\..\Views\Register\Index.cshtml"
Write(Html.FormCheckBoxFor(m => m.HasAcceptedTermsAndConditions, labelHtmlAttributes: new { @class = "block-label" }));

            
            #line default
            #line hidden
            
            #line 57 "..\..\Views\Register\Index.cshtml"
                                                                                                                    


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <button");

WriteLiteral(" id=\"create-account-btn\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(">Create account</button>\r\n    </div>\r\n");

            
            #line 62 "..\..\Views\Register\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 66 "..\..\Views\Register\Index.cshtml"
Write(Scripts.Render("~/bundles/nas/passwordstrength"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <script>\r\n        $(function () {\r\n\r\n            $(\"#find-addresses\").add" +
"ressLookup({\r\n                url: \'");

            
            #line 72 "..\..\Views\Register\Index.cshtml"
                 Write(Url.Action("Addresses", "Location"));

            
            #line default
            #line hidden
WriteLiteral("\',\r\n                selectlist: \'#address-select\'\r\n            });\r\n\r\n           " +
" $(\'input[id=EmailAddress]\').usernameLookup(\'");

            
            #line 76 "..\..\Views\Register\Index.cshtml"
                                                   Write(Url.Action("CheckUsername", "Register"));

            
            #line default
            #line hidden
WriteLiteral("\');\r\n        });\r\n\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591