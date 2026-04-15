
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant260Role
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
    public static class UserEventPayloadVariant260RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant260Role value)
        {
            return value switch
            {
                UserEventPayloadVariant260Role.Billing => "BILLING",
                UserEventPayloadVariant260Role.Contributor => "CONTRIBUTOR",
                UserEventPayloadVariant260Role.Developer => "DEVELOPER",
                UserEventPayloadVariant260Role.Member => "MEMBER",
                UserEventPayloadVariant260Role.Owner => "OWNER",
                UserEventPayloadVariant260Role.Security => "SECURITY",
                UserEventPayloadVariant260Role.Viewer => "VIEWER",
                UserEventPayloadVariant260Role.ViewerForPlus => "VIEWER_FOR_PLUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant260Role? ToEnum(string value)
        {
            return value switch
            {
                "BILLING" => UserEventPayloadVariant260Role.Billing,
                "CONTRIBUTOR" => UserEventPayloadVariant260Role.Contributor,
                "DEVELOPER" => UserEventPayloadVariant260Role.Developer,
                "MEMBER" => UserEventPayloadVariant260Role.Member,
                "OWNER" => UserEventPayloadVariant260Role.Owner,
                "SECURITY" => UserEventPayloadVariant260Role.Security,
                "VIEWER" => UserEventPayloadVariant260Role.Viewer,
                "VIEWER_FOR_PLUS" => UserEventPayloadVariant260Role.ViewerForPlus,
                _ => null,
            };
        }
    }
}