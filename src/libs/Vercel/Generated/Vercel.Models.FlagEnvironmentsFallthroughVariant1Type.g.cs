
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagEnvironmentsFallthroughVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Variant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FlagEnvironmentsFallthroughVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagEnvironmentsFallthroughVariant1Type value)
        {
            return value switch
            {
                FlagEnvironmentsFallthroughVariant1Type.Variant => "variant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagEnvironmentsFallthroughVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "variant" => FlagEnvironmentsFallthroughVariant1Type.Variant,
                _ => null,
            };
        }
    }
}