﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="403.aspx.cs" Inherits="SFA.Apprenticeships.Web.Candidate._403" %>

<!DOCTYPE html>
<!--[if lt IE 7]><html class="no-js lt-ie9 lt-ie8 lt-ie7"><![endif]-->
<!--[if IE 7]><html class="no-js lt-ie9 lt-ie8"><![endif]-->
<!--[if IE 8]><html class="no-js lt-ie9"><![endif]-->
<!--[if gt IE 8]><!-->
<html lang="en-GB" class="not-ie8">
<!--<![endif]-->
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!--[if gt IE 8]><!--><link href="//az693499.vo.msecnd.net/prod/css/main.css" rel="stylesheet" /><!--<![endif]-->
    <!--[if lte IE 8]><link href="//az693499.vo.msecnd.net/prod/css/main-ie8.css" rel="stylesheet" /><![endif]-->
    <!--[if lte IE 8]><link href="//az693499.vo.msecnd.net/prod/css/fonts-ie8.css" rel="stylesheet" /><![endif]-->
    <!--[if gte IE 9]><!--><link href="//az693499.vo.msecnd.net/prod/css/fonts.css" rel="stylesheet" /><!--<![endif]-->
    <link rel="shortcut icon" href="//az693499.vo.msecnd.net/prod/img/favicon.ico" type="image/x-icon">
    <link href="//az693499.vo.msecnd.net/prod/css/font-awesome/css/font-awesome.min.css" rel="stylesheet" />
    <script type="text/javascript" src="/Content/_assets/js/vendor/modernizr-custom.js"></script>
</head>
<body>
   <%-- <div class="skiplink-container">
        <div>
            <a href="#main" class="skiplink">Skip to main content</a>
        </div>
    </div>--%>
    <header role="banner" class="global-header">
        <div class="global-header__wrapper">
            <div class="global-header__logo">
                <a href="http://gov.uk" title="Go to the GOV.UK homepage" class="govuk-logo">
                    <img src="//az693499.vo.msecnd.net/prod/img/gov.uk_logotype_crown.png" alt="Crown">
                GOV.UK
                </a>
            </div>
            <div class="global-header__nav">
                <h2 runat="server" id="HeaderTitle" class="global-header__title beta">Find an apprenticeship</h2>
            </div>
        </div>
    </header>
    <div class="content-container">
        <div class="phase-notice gov-border">
            <div class="prototype-warning">
                <strong class="beta__label">Beta</strong> <span>This is a new services – your <a rel="external" href="https://www.surveymonkey.com/s/MFNR7NZ" target="_blank">feedback</a> will help to improve it.</span>
            </div>
        </div>
        <main role="main" id="main">
            <h1 class="heading-xlarge">Service is currently down for maintenance</h1>
            <div class="text">
                <p><asp:Label runat="server" ID="OfflineMessageLabel" ></asp:Label></p>
            </div>
        </main>
    </div>

    <footer class="gov-border" role="contentinfo">
        <div class="footer__wrapper">
            <div class="footer__meta">
                <ul class="footer__nav" role="navigation">
                    <li class="footer__link">Built by the <a href="http://gov.uk/sfa" target="_blank">Skills Funding Agency</a></li>
                    <li class="footer__ogl"><a href="http://www.nationalarchives.gov.uk/doc/open-government-licence/version/2" class="ir ogl-logo">OGL</a>All content is available under the <a href="http://www.nationalarchives.gov.uk/doc/open-government-licence/version/2">Open Government Licence v2.0</a>, except where otherwise stated</li>
                </ul>
                <a class="footer__copyright" href="http://www.nationalarchives.gov.uk/information-management/our-services/crown-copyright.htm" target="_blank">
                    <img src="//az693499.vo.msecnd.net/prod/img/govuk-crest-2x.png" width="125" height="102" alt="Crown copyright logo">
                    <p>&copy; Crown copyright</p>
                </a>
            </div>
        </div>
    </footer>

</body>
</html>
