
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether to create a new team under the organization (\"create\") or link an existing one (\"link\").
    /// </summary>
    public enum AddOrganizationTeamRequestMode
    {
        /// <summary>
        ///
        /// </summary>
        Create,
        /// <summary>
        ///
        /// </summary>
        Link,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddOrganizationTeamRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddOrganizationTeamRequestMode value)
        {
            return value switch
            {
                AddOrganizationTeamRequestMode.Create => "create",
                AddOrganizationTeamRequestMode.Link => "link",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddOrganizationTeamRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "create" => AddOrganizationTeamRequestMode.Create,
                "link" => AddOrganizationTeamRequestMode.Link,
                _ => null,
            };
        }
    }
}