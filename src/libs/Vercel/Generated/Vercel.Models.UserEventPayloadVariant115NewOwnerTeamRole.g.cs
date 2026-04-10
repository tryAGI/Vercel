
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerTeamRole
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
    public static class UserEventPayloadVariant115NewOwnerTeamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerTeamRole value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerTeamRole.Billing => "BILLING",
                UserEventPayloadVariant115NewOwnerTeamRole.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant115NewOwnerTeamRole.Developer => "DEVELOPER",
                UserEventPayloadVariant115NewOwnerTeamRole.Member => "MEMBER",
                UserEventPayloadVariant115NewOwnerTeamRole.Owner => "OWNER",
                UserEventPayloadVariant115NewOwnerTeamRole.Security => "SECURITY",
                UserEventPayloadVariant115NewOwnerTeamRole.Viewer => "VIEWER",
                UserEventPayloadVariant115NewOwnerTeamRole.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerTeamRole? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant115NewOwnerTeamRole.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant115NewOwnerTeamRole.Contributor,
                "DEVELOPER" => UserEventPayloadVariant115NewOwnerTeamRole.Developer,
                "MEMBER" => UserEventPayloadVariant115NewOwnerTeamRole.Member,
                "OWNER" => UserEventPayloadVariant115NewOwnerTeamRole.Owner,
                "SECURITY" => UserEventPayloadVariant115NewOwnerTeamRole.Security,
                "VIEWER" => UserEventPayloadVariant115NewOwnerTeamRole.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant115NewOwnerTeamRole.ViewerForPlus,
                _ => null,
            };
        }
    }
}