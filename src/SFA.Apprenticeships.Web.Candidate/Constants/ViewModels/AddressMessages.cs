﻿namespace SFA.Apprenticeships.Web.Candidate.Constants.ViewModels
{
    public static class AddressMessages
    {
        public static class AddressLine1
        {
            public const string LabelText = "First line of address";
            public const string RequiredErrorText = "'First line of address' must be supplied";
            public const string TooLongErrorText = "'First line of address' must not exceed xxxx characters";
            public const string WhiteListRegularExpression = Whitelists.FreetextWhitelist.RegularExpression;
            public const string WhiteListErrorText = "'First line of address' " + Whitelists.FreetextWhitelist.ErrorText;
        }

        public static class AddressLine2
        {
            public const string LabelText = "Second line (optional)";
            public const string TooLongErrorText = "'Second line of address' must not exceed xxxx characters";
            public const string WhiteListRegularExpression = Whitelists.FreetextWhitelist.RegularExpression;
            public const string WhiteListErrorText = "'Second line of address' " + Whitelists.FreetextWhitelist.ErrorText;
        }

        public static class AddressLine3
        {
            public const string LabelText = "Town or city";
            public const string RequiredErrorText = "'Town or city' must be supplied";
            public const string TooLongErrorText = "'Town or city' must not exceed xxxx characters";
            public const string WhiteListRegularExpression = Whitelists.FreetextWhitelist.RegularExpression;
            public const string WhiteListErrorText = "'Town or city' " + Whitelists.FreetextWhitelist.ErrorText;
        }

        public static class AddressLine4
        {
            public const string LabelText = "County";
            public const string RequiredErrorText = "'County' must be supplied";
            public const string TooLongErrorText = "'County' must not exceed xxxx characters";
            public const string WhiteListRegularExpression = Whitelists.FreetextWhitelist.RegularExpression;
            public const string WhiteListErrorText = "'County' " + Whitelists.FreetextWhitelist.ErrorText;
        }

        public static class Postcode
        {
            public const string LabelText = "Post code";
            public const string RequiredErrorText = "'Post code' must be supplied";
            public const string WhiteListRegularExpression = Whitelists.PostcodeWhitelist.RegularExpression;
            public const string WhiteListErrorText = "'Post code' " + Whitelists.PostcodeWhitelist.ErrorText;
        }
    }
}