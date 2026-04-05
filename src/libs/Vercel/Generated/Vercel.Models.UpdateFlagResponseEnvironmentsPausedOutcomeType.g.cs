
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseEnvironmentsPausedOutcomeType
    {
        /// <summary>
        /// 
        /// </summary>
        Variant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagResponseEnvironmentsPausedOutcomeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseEnvironmentsPausedOutcomeType value)
        {
            return value switch
            {
                UpdateFlagResponseEnvironmentsPausedOutcomeType.Variant => "variant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseEnvironmentsPausedOutcomeType? ToEnum(string value)
        {
            return value switch
            {
                "variant" => UpdateFlagResponseEnvironmentsPausedOutcomeType.Variant,
                _ => null,
            };
        }
    }
}