
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared362c8e760cc311d9Role
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
    public static class AutoSDKShared362c8e760cc311d9RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared362c8e760cc311d9Role value)
        {
            return value switch
            {
                AutoSDKShared362c8e760cc311d9Role.Billing => "BILLING",
                AutoSDKShared362c8e760cc311d9Role.Contributor => "CONTRIBUTOR",
                AutoSDKShared362c8e760cc311d9Role.Developer => "DEVELOPER",
                AutoSDKShared362c8e760cc311d9Role.Member => "MEMBER",
                AutoSDKShared362c8e760cc311d9Role.Owner => "OWNER",
                AutoSDKShared362c8e760cc311d9Role.Security => "SECURITY",
                AutoSDKShared362c8e760cc311d9Role.Viewer => "VIEWER",
                AutoSDKShared362c8e760cc311d9Role.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared362c8e760cc311d9Role? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => AutoSDKShared362c8e760cc311d9Role.Billing,
                "CONTRIBUTOR" => AutoSDKShared362c8e760cc311d9Role.Contributor,
                "DEVELOPER" => AutoSDKShared362c8e760cc311d9Role.Developer,
                "MEMBER" => AutoSDKShared362c8e760cc311d9Role.Member,
                "OWNER" => AutoSDKShared362c8e760cc311d9Role.Owner,
                "SECURITY" => AutoSDKShared362c8e760cc311d9Role.Security,
                "VIEWER" => AutoSDKShared362c8e760cc311d9Role.Viewer,
                "VIEWER_FOR_PLUS" => AutoSDKShared362c8e760cc311d9Role.ViewerForPlus,
                _ => null,
            };
        }
    }
}