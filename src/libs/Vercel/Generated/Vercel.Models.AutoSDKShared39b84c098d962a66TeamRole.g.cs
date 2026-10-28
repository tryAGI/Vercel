
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared39b84c098d962a66TeamRole
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
    public static class AutoSDKShared39b84c098d962a66TeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared39b84c098d962a66TeamRole value)
        {
            return value switch
            {
                AutoSDKShared39b84c098d962a66TeamRole.Billing => "BILLING",
                AutoSDKShared39b84c098d962a66TeamRole.Contributor => "CONTRIBUTOR",
                AutoSDKShared39b84c098d962a66TeamRole.Developer => "DEVELOPER",
                AutoSDKShared39b84c098d962a66TeamRole.Member => "MEMBER",
                AutoSDKShared39b84c098d962a66TeamRole.Owner => "OWNER",
                AutoSDKShared39b84c098d962a66TeamRole.Security => "SECURITY",
                AutoSDKShared39b84c098d962a66TeamRole.Viewer => "VIEWER",
                AutoSDKShared39b84c098d962a66TeamRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared39b84c098d962a66TeamRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => AutoSDKShared39b84c098d962a66TeamRole.Billing,
                "CONTRIBUTOR" => AutoSDKShared39b84c098d962a66TeamRole.Contributor,
                "DEVELOPER" => AutoSDKShared39b84c098d962a66TeamRole.Developer,
                "MEMBER" => AutoSDKShared39b84c098d962a66TeamRole.Member,
                "OWNER" => AutoSDKShared39b84c098d962a66TeamRole.Owner,
                "SECURITY" => AutoSDKShared39b84c098d962a66TeamRole.Security,
                "VIEWER" => AutoSDKShared39b84c098d962a66TeamRole.Viewer,
                "VIEWER_FOR_PLUS" => AutoSDKShared39b84c098d962a66TeamRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}