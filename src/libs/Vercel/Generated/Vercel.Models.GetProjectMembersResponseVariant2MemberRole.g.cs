
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Role of this user in the project.<br/>
    /// Example: ADMIN
    /// </summary>
    public enum GetProjectMembersResponseVariant2MemberRole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        ProjectDeveloper,
        /// <summary>
        /// 
        /// </summary>
        ProjectGuest,
        /// <summary>
        /// 
        /// </summary>
        ProjectViewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectMembersResponseVariant2MemberRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectMembersResponseVariant2MemberRole value)
        {
            return value switch
            {
                GetProjectMembersResponseVariant2MemberRole.Admin => "ADMIN",
                GetProjectMembersResponseVariant2MemberRole.ProjectDeveloper => "PROJECT_DEVELOPER",
                GetProjectMembersResponseVariant2MemberRole.ProjectGuest => "PROJECT_GUEST",
                GetProjectMembersResponseVariant2MemberRole.ProjectViewer => "PROJECT_VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectMembersResponseVariant2MemberRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => GetProjectMembersResponseVariant2MemberRole.Admin,
                "PROJECT_DEVELOPER" => GetProjectMembersResponseVariant2MemberRole.ProjectDeveloper,
                "PROJECT_GUEST" => GetProjectMembersResponseVariant2MemberRole.ProjectGuest,
                "PROJECT_VIEWER" => GetProjectMembersResponseVariant2MemberRole.ProjectViewer,
                _ => null,
            };
        }
    }
}