
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditProjectEnvResponseContentHintVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        RedisUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditProjectEnvResponseContentHintVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditProjectEnvResponseContentHintVariant1Type value)
        {
            return value switch
            {
                EditProjectEnvResponseContentHintVariant1Type.RedisUrl => "redis-url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditProjectEnvResponseContentHintVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "redis-url" => EditProjectEnvResponseContentHintVariant1Type.RedisUrl,
                _ => null,
            };
        }
    }
}