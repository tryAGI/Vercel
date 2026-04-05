
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectEnvResponseVariant2ContentHintVariant11Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresPassword,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectEnvResponseVariant2ContentHintVariant11TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectEnvResponseVariant2ContentHintVariant11Type value)
        {
            return value switch
            {
                GetProjectEnvResponseVariant2ContentHintVariant11Type.PostgresPassword => "postgres-password",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectEnvResponseVariant2ContentHintVariant11Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-password" => GetProjectEnvResponseVariant2ContentHintVariant11Type.PostgresPassword,
                _ => null,
            };
        }
    }
}