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

namespace SFA.Apprenticeships.Web.Candidate.Views.TraineeshipApplication.EditorTemplates
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/TraineeshipApplication/EditorTemplates/EmployerQuestionAnswersViewModel.c" +
        "shtml")]
    public partial class EmployerQuestionAnswersViewModel_ : System.Web.Mvc.WebViewPage<EmployerQuestionAnswersViewModel>
    {
        public EmployerQuestionAnswersViewModel_()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\TraineeshipApplication\EditorTemplates\EmployerQuestionAnswersViewModel.cshtml"
 if (Model != null && (!string.IsNullOrWhiteSpace(Model.SupplementaryQuestion1) || !string.IsNullOrWhiteSpace(Model.SupplementaryQuestion2)))
{

            
            #line default
            #line hidden
WriteLiteral("    <fieldset");

WriteLiteral(" id=\"applyEmployerQuestionAnswers\"");

WriteLiteral(">\r\n        <legend");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">Additional questions</legend>\r\n\r\n");

            
            #line 8 "..\..\Views\TraineeshipApplication\EditorTemplates\EmployerQuestionAnswersViewModel.cshtml"
        
            
            #line default
            #line hidden
            
            #line 8 "..\..\Views\TraineeshipApplication\EditorTemplates\EmployerQuestionAnswersViewModel.cshtml"
         if (!string.IsNullOrWhiteSpace(Model.SupplementaryQuestion1))
        {
            
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\TraineeshipApplication\EditorTemplates\EmployerQuestionAnswersViewModel.cshtml"
       Write(Html.HiddenFor(m => m.SupplementaryQuestion1));

            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\TraineeshipApplication\EditorTemplates\EmployerQuestionAnswersViewModel.cshtml"
                                                          
            
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\TraineeshipApplication\EditorTemplates\EmployerQuestionAnswersViewModel.cshtml"
       Write(Html.FormTextAreaFor(m => m.CandidateAnswer1, labelText: Model.SupplementaryQuestion1, controlHtmlAttributes: new { rows = "4", role = "textbox", aria_multiline = "true" }, hintHtmlAttributes: new { @class = "text" }, labelHtmlAttributes: new { @class = "text" }));

            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\TraineeshipApplication\EditorTemplates\EmployerQuestionAnswersViewModel.cshtml"
                                                                                                                                                                                                                                                                                    
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 14 "..\..\Views\TraineeshipApplication\EditorTemplates\EmployerQuestionAnswersViewModel.cshtml"
        
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\TraineeshipApplication\EditorTemplates\EmployerQuestionAnswersViewModel.cshtml"
         if (!string.IsNullOrWhiteSpace(Model.SupplementaryQuestion2))
        {
            
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\TraineeshipApplication\EditorTemplates\EmployerQuestionAnswersViewModel.cshtml"
       Write(Html.HiddenFor(m => m.SupplementaryQuestion2));

            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\TraineeshipApplication\EditorTemplates\EmployerQuestionAnswersViewModel.cshtml"
                                                          
            
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\TraineeshipApplication\EditorTemplates\EmployerQuestionAnswersViewModel.cshtml"
       Write(Html.FormTextAreaFor(m => m.CandidateAnswer2, labelText: Model.SupplementaryQuestion2, controlHtmlAttributes: new { rows = "4", role = "textbox", aria_multiline = "true" }, hintHtmlAttributes: new { @class = "text" }, labelHtmlAttributes: new { @class = "text" }));

            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\TraineeshipApplication\EditorTemplates\EmployerQuestionAnswersViewModel.cshtml"
                                                                                                                                                                                                                                                                                    
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n    </fieldset>\r\n");

            
            #line 21 "..\..\Views\TraineeshipApplication\EditorTemplates\EmployerQuestionAnswersViewModel.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591