
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagEnvironmentsPausedOutcomeType
    {
        /// <summary>
        /// 
        /// </summary>
        Variant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FlagEnvironmentsPausedOutcomeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagEnvironmentsPausedOutcomeType value)
        {
            return value switch
            {
                FlagEnvironmentsPausedOutcomeType.Variant => "variant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagEnvironmentsPausedOutcomeType? ToEnum(string value)
        {
            return value switch
            {
                "variant" => FlagEnvironmentsPausedOutcomeType.Variant,
                _ => null,
            };
        }
    }
}