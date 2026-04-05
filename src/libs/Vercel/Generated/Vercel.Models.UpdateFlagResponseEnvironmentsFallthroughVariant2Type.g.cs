
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseEnvironmentsFallthroughVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Split,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagResponseEnvironmentsFallthroughVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseEnvironmentsFallthroughVariant2Type value)
        {
            return value switch
            {
                UpdateFlagResponseEnvironmentsFallthroughVariant2Type.Split => "split",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseEnvironmentsFallthroughVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "split" => UpdateFlagResponseEnvironmentsFallthroughVariant2Type.Split,
                _ => null,
            };
        }
    }
}