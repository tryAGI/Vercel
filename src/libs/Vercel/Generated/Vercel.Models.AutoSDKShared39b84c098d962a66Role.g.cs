
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared39b84c098d962a66Role
    {
        /// <summary>
        ///
        /// </summary>
        Billing,
        /// <summary>
        ///
        /// </summary>
        Contributor,
        /// <summary>
        ///
        /// </summary>
        Developer,
        /// <summary>
        ///
        /// </summary>
        Member,
        /// <summary>
        ///
        /// </summary>
        Owner,
        /// <summary>
        ///
        /// </summary>
        Security,
        /// <summary>
        ///
        /// </summary>
        Viewer,
        /// <summary>
        ///
        /// </summary>
        ViewerForPlus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared39b84c098d962a66RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared39b84c098d962a66Role value)
        {
            return value switch
            {
                AutoSDKShared39b84c098d962a66Role.Billing => "BILLING",
                AutoSDKShared39b84c098d962a66Role.Contributor => "CONTRIBUTOR",
                AutoSDKShared39b84c098d962a66Role.Developer => "DEVELOPER",
                AutoSDKShared39b84c098d962a66Role.Member => "MEMBER",
                AutoSDKShared39b84c098d962a66Role.Owner => "OWNER",
                AutoSDKShared39b84c098d962a66Role.Security => "SECURITY",
                AutoSDKShared39b84c098d962a66Role.Viewer => "VIEWER",
                AutoSDKShared39b84c098d962a66Role.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared39b84c098d962a66Role? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => AutoSDKShared39b84c098d962a66Role.Billing,
                "CONTRIBUTOR" => AutoSDKShared39b84c098d962a66Role.Contributor,
                "DEVELOPER" => AutoSDKShared39b84c098d962a66Role.Developer,
                "MEMBER" => AutoSDKShared39b84c098d962a66Role.Member,
                "OWNER" => AutoSDKShared39b84c098d962a66Role.Owner,
                "SECURITY" => AutoSDKShared39b84c098d962a66Role.Security,
                "VIEWER" => AutoSDKShared39b84c098d962a66Role.Viewer,
                "VIEWER_FOR_PLUS" => AutoSDKShared39b84c098d962a66Role.ViewerForPlus,
                _ => null,
            };
        }
    }
}