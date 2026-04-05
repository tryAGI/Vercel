
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagEnvironmentsFallthroughVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Split,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FlagEnvironmentsFallthroughVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagEnvironmentsFallthroughVariant2Type value)
        {
            return value switch
            {
                FlagEnvironmentsFallthroughVariant2Type.Split => "split",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagEnvironmentsFallthroughVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "split" => FlagEnvironmentsFallthroughVariant2Type.Split,
                _ => null,
            };
        }
    }
}