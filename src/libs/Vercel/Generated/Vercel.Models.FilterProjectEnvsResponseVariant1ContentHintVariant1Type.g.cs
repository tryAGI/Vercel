
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterProjectEnvsResponseVariant1ContentHintVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        RedisUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterProjectEnvsResponseVariant1ContentHintVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant1ContentHintVariant1Type value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant1ContentHintVariant1Type.RedisUrl => "redis-url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant1ContentHintVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "redis-url" => FilterProjectEnvsResponseVariant1ContentHintVariant1Type.RedisUrl,
                _ => null,
            };
        }
    }
}