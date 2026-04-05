
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveProjectEnvResponseVariant2ContentHintVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveProjectEnvResponseVariant2ContentHintVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant2ContentHintVariant6Type value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant2ContentHintVariant6Type.PostgresUrl => "postgres-url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant2ContentHintVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-url" => RemoveProjectEnvResponseVariant2ContentHintVariant6Type.PostgresUrl,
                _ => null,
            };
        }
    }
}