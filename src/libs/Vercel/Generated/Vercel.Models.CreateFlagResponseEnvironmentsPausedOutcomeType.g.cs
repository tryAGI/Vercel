
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseEnvironmentsPausedOutcomeType
    {
        /// <summary>
        /// 
        /// </summary>
        Variant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFlagResponseEnvironmentsPausedOutcomeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseEnvironmentsPausedOutcomeType value)
        {
            return value switch
            {
                CreateFlagResponseEnvironmentsPausedOutcomeType.Variant => "variant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseEnvironmentsPausedOutcomeType? ToEnum(string value)
        {
            return value switch
            {
                "variant" => CreateFlagResponseEnvironmentsPausedOutcomeType.Variant,
                _ => null,
            };
        }
    }
}