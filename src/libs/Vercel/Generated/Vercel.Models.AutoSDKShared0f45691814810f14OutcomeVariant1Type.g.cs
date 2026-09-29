
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0f45691814810f14OutcomeVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Variant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0f45691814810f14OutcomeVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0f45691814810f14OutcomeVariant1Type value)
        {
            return value switch
            {
                AutoSDKShared0f45691814810f14OutcomeVariant1Type.Variant => "variant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0f45691814810f14OutcomeVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "variant" => AutoSDKShared0f45691814810f14OutcomeVariant1Type.Variant,
                _ => null,
            };
        }
    }
}