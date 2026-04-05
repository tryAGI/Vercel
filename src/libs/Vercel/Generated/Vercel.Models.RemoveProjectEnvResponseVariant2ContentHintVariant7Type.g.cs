
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveProjectEnvResponseVariant2ContentHintVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresUrlNonPooling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveProjectEnvResponseVariant2ContentHintVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant2ContentHintVariant7Type value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant2ContentHintVariant7Type.PostgresUrlNonPooling => "postgres-url-non-pooling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant2ContentHintVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-url-non-pooling" => RemoveProjectEnvResponseVariant2ContentHintVariant7Type.PostgresUrlNonPooling,
                _ => null,
            };
        }
    }
}