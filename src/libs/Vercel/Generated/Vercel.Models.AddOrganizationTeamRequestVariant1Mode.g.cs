
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AddOrganizationTeamRequestVariant1Mode
    {
        /// <summary>
        ///
        /// </summary>
        Create,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddOrganizationTeamRequestVariant1ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddOrganizationTeamRequestVariant1Mode value)
        {
            return value switch
            {
                AddOrganizationTeamRequestVariant1Mode.Create => "create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddOrganizationTeamRequestVariant1Mode? ToEnum(string value)
        {
            return value switch
            {
                "create" => AddOrganizationTeamRequestVariant1Mode.Create,
                _ => null,
            };
        }
    }
}