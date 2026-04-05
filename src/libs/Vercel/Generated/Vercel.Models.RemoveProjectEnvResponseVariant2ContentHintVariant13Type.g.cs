
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveProjectEnvResponseVariant2ContentHintVariant13Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresUrlNoSsl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveProjectEnvResponseVariant2ContentHintVariant13TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant2ContentHintVariant13Type value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant2ContentHintVariant13Type.PostgresUrlNoSsl => "postgres-url-no-ssl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant2ContentHintVariant13Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-url-no-ssl" => RemoveProjectEnvResponseVariant2ContentHintVariant13Type.PostgresUrlNoSsl,
                _ => null,
            };
        }
    }
}