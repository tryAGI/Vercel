
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveProjectEnvResponseVariant3ContentHintVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresUrlNonPooling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveProjectEnvResponseVariant3ContentHintVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant3ContentHintVariant7Type value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant3ContentHintVariant7Type.PostgresUrlNonPooling => "postgres-url-non-pooling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant3ContentHintVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-url-non-pooling" => RemoveProjectEnvResponseVariant3ContentHintVariant7Type.PostgresUrlNonPooling,
                _ => null,
            };
        }
    }
}