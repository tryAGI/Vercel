
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1e1af2b60dfcf13aPausedOutcomeType
    {
        /// <summary>
        ///
        /// </summary>
        Variant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared1e1af2b60dfcf13aPausedOutcomeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1e1af2b60dfcf13aPausedOutcomeType value)
        {
            return value switch
            {
                AutoSDKShared1e1af2b60dfcf13aPausedOutcomeType.Variant => "variant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1e1af2b60dfcf13aPausedOutcomeType? ToEnum(string value)
        {
            return value switch
            {
                "variant" => AutoSDKShared1e1af2b60dfcf13aPausedOutcomeType.Variant,
                _ => null,
            };
        }
    }
}