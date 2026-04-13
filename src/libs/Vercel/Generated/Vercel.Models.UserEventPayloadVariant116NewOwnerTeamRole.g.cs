
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerTeamRole
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
    public static class UserEventPayloadVariant116NewOwnerTeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerTeamRole value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerTeamRole.Billing => "BILLING",
                UserEventPayloadVariant116NewOwnerTeamRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant116NewOwnerTeamRole.Developer => "DEVELOPER",
                UserEventPayloadVariant116NewOwnerTeamRole.Member => "MEMBER",
                UserEventPayloadVariant116NewOwnerTeamRole.Owner => "OWNER",
                UserEventPayloadVariant116NewOwnerTeamRole.Security => "SECURITY",
                UserEventPayloadVariant116NewOwnerTeamRole.Viewer => "VIEWER",
                UserEventPayloadVariant116NewOwnerTeamRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerTeamRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant116NewOwnerTeamRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant116NewOwnerTeamRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant116NewOwnerTeamRole.Developer,
                "MEMBER" => UserEventPayloadVariant116NewOwnerTeamRole.Member,
                "OWNER" => UserEventPayloadVariant116NewOwnerTeamRole.Owner,
                "SECURITY" => UserEventPayloadVariant116NewOwnerTeamRole.Security,
                "VIEWER" => UserEventPayloadVariant116NewOwnerTeamRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant116NewOwnerTeamRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}