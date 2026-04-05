
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseEnvironmentsFallthroughVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Variant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagResponseEnvironmentsFallthroughVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseEnvironmentsFallthroughVariant1Type value)
        {
            return value switch
            {
                UpdateFlagResponseEnvironmentsFallthroughVariant1Type.Variant => "variant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseEnvironmentsFallthroughVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "variant" => UpdateFlagResponseEnvironmentsFallthroughVariant1Type.Variant,
                _ => null,
            };
        }
    }
}