
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AddOrganizationTeamRequestVariant2Mode
    {
        /// <summary>
        ///
        /// </summary>
        Link,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddOrganizationTeamRequestVariant2ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddOrganizationTeamRequestVariant2Mode value)
        {
            return value switch
            {
                AddOrganizationTeamRequestVariant2Mode.Link => "link",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddOrganizationTeamRequestVariant2Mode? ToEnum(string value)
        {
            return value switch
            {
                "link" => AddOrganizationTeamRequestVariant2Mode.Link,
                _ => null,
            };
        }
    }
}