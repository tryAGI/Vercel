
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum PutOrganizationDsyncGroupRequestAssignmentsOrganizationPermission
    {
        /// <summary>
        ///
        /// </summary>
        OrgAdmin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutOrganizationDsyncGroupRequestAssignmentsOrganizationPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutOrganizationDsyncGroupRequestAssignmentsOrganizationPermission value)
        {
            return value switch
            {
                PutOrganizationDsyncGroupRequestAssignmentsOrganizationPermission.OrgAdmin => "OrgAdmin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutOrganizationDsyncGroupRequestAssignmentsOrganizationPermission? ToEnum(string value)
        {
            return value switch
            {
                "OrgAdmin" => PutOrganizationDsyncGroupRequestAssignmentsOrganizationPermission.OrgAdmin,
                _ => null,
            };
        }
    }
}