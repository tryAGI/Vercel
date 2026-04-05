
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerTeamRole
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
    public static class UserEventPayloadVariant114NewOwnerTeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerTeamRole value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerTeamRole.Billing => "BILLING",
                UserEventPayloadVariant114NewOwnerTeamRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant114NewOwnerTeamRole.Developer => "DEVELOPER",
                UserEventPayloadVariant114NewOwnerTeamRole.Member => "MEMBER",
                UserEventPayloadVariant114NewOwnerTeamRole.Owner => "OWNER",
                UserEventPayloadVariant114NewOwnerTeamRole.Security => "SECURITY",
                UserEventPayloadVariant114NewOwnerTeamRole.Viewer => "VIEWER",
                UserEventPayloadVariant114NewOwnerTeamRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerTeamRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant114NewOwnerTeamRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant114NewOwnerTeamRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant114NewOwnerTeamRole.Developer,
                "MEMBER" => UserEventPayloadVariant114NewOwnerTeamRole.Member,
                "OWNER" => UserEventPayloadVariant114NewOwnerTeamRole.Owner,
                "SECURITY" => UserEventPayloadVariant114NewOwnerTeamRole.Security,
                "VIEWER" => UserEventPayloadVariant114NewOwnerTeamRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant114NewOwnerTeamRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}