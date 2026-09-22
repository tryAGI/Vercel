
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0f637bb8b5caf2d6RuleOutcomeVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0f637bb8b5caf2d6RuleOutcomeVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0f637bb8b5caf2d6RuleOutcomeVariant1Type value)
        {
            return value switch
            {
                AutoSDKShared0f637bb8b5caf2d6RuleOutcomeVariant1Type.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0f637bb8b5caf2d6RuleOutcomeVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared0f637bb8b5caf2d6RuleOutcomeVariant1Type.All,
                _ => null,
            };
        }
    }
}