
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseEnvironmentsFallthroughVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Split,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFlagResponseEnvironmentsFallthroughVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseEnvironmentsFallthroughVariant2Type value)
        {
            return value switch
            {
                CreateFlagResponseEnvironmentsFallthroughVariant2Type.Split => "split",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseEnvironmentsFallthroughVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "split" => CreateFlagResponseEnvironmentsFallthroughVariant2Type.Split,
                _ => null,
            };
        }
    }
}