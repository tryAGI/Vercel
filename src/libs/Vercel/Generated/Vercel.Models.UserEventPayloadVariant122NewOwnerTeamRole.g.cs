
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerTeamRole
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
    public static class UserEventPayloadVariant122NewOwnerTeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerTeamRole value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerTeamRole.Billing => "BILLING",
                UserEventPayloadVariant122NewOwnerTeamRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant122NewOwnerTeamRole.Developer => "DEVELOPER",
                UserEventPayloadVariant122NewOwnerTeamRole.Member => "MEMBER",
                UserEventPayloadVariant122NewOwnerTeamRole.Owner => "OWNER",
                UserEventPayloadVariant122NewOwnerTeamRole.Security => "SECURITY",
                UserEventPayloadVariant122NewOwnerTeamRole.Viewer => "VIEWER",
                UserEventPayloadVariant122NewOwnerTeamRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerTeamRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant122NewOwnerTeamRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant122NewOwnerTeamRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant122NewOwnerTeamRole.Developer,
                "MEMBER" => UserEventPayloadVariant122NewOwnerTeamRole.Member,
                "OWNER" => UserEventPayloadVariant122NewOwnerTeamRole.Owner,
                "SECURITY" => UserEventPayloadVariant122NewOwnerTeamRole.Security,
                "VIEWER" => UserEventPayloadVariant122NewOwnerTeamRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant122NewOwnerTeamRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}