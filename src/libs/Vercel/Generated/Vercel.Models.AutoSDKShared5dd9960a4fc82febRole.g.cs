
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5dd9960a4fc82febRole
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
    public static class AutoSDKShared5dd9960a4fc82febRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5dd9960a4fc82febRole value)
        {
            return value switch
            {
                AutoSDKShared5dd9960a4fc82febRole.Billing => "BILLING",
                AutoSDKShared5dd9960a4fc82febRole.Contributor => "CONTRIBUTOR",
                AutoSDKShared5dd9960a4fc82febRole.Developer => "DEVELOPER",
                AutoSDKShared5dd9960a4fc82febRole.Member => "MEMBER",
                AutoSDKShared5dd9960a4fc82febRole.Owner => "OWNER",
                AutoSDKShared5dd9960a4fc82febRole.Security => "SECURITY",
                AutoSDKShared5dd9960a4fc82febRole.Viewer => "VIEWER",
                AutoSDKShared5dd9960a4fc82febRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5dd9960a4fc82febRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => AutoSDKShared5dd9960a4fc82febRole.Billing,
                "CONTRIBUTOR" => AutoSDKShared5dd9960a4fc82febRole.Contributor,
                "DEVELOPER" => AutoSDKShared5dd9960a4fc82febRole.Developer,
                "MEMBER" => AutoSDKShared5dd9960a4fc82febRole.Member,
                "OWNER" => AutoSDKShared5dd9960a4fc82febRole.Owner,
                "SECURITY" => AutoSDKShared5dd9960a4fc82febRole.Security,
                "VIEWER" => AutoSDKShared5dd9960a4fc82febRole.Viewer,
                "VIEWER_FOR_PLUS" => AutoSDKShared5dd9960a4fc82febRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}