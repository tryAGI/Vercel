
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum OrganizationDirectorySyncGroupAssignmentsOrganizationPermission
    {
        /// <summary>
        ///
        /// </summary>
        OrgAdmin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationDirectorySyncGroupAssignmentsOrganizationPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationDirectorySyncGroupAssignmentsOrganizationPermission value)
        {
            return value switch
            {
                OrganizationDirectorySyncGroupAssignmentsOrganizationPermission.OrgAdmin => "OrgAdmin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationDirectorySyncGroupAssignmentsOrganizationPermission? ToEnum(string value)
        {
            return value switch
            {
                "OrgAdmin" => OrganizationDirectorySyncGroupAssignmentsOrganizationPermission.OrgAdmin,
                _ => null,
            };
        }
    }
}