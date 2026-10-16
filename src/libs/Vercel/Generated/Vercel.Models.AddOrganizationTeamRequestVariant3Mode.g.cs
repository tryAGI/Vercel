
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AddOrganizationTeamRequestVariant3Mode
    {
        /// <summary>
        ///
        /// </summary>
        Link,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddOrganizationTeamRequestVariant3ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddOrganizationTeamRequestVariant3Mode value)
        {
            return value switch
            {
                AddOrganizationTeamRequestVariant3Mode.Link => "link",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddOrganizationTeamRequestVariant3Mode? ToEnum(string value)
        {
            return value switch
            {
                "link" => AddOrganizationTeamRequestVariant3Mode.Link,
                _ => null,
            };
        }
    }
}