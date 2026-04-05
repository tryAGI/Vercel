
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectEnvItemContentHintVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresUrlNonPooling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant3ProjectEnvItemContentHintVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectEnvItemContentHintVariant7Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectEnvItemContentHintVariant7Type.PostgresUrlNonPooling => "postgres-url-non-pooling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectEnvItemContentHintVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-url-non-pooling" => GetProjectsResponseVariant3ProjectEnvItemContentHintVariant7Type.PostgresUrlNonPooling,
                _ => null,
            };
        }
    }
}