
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectEnvResponseVariant2ContentHintVariant10Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresHost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectEnvResponseVariant2ContentHintVariant10TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectEnvResponseVariant2ContentHintVariant10Type value)
        {
            return value switch
            {
                GetProjectEnvResponseVariant2ContentHintVariant10Type.PostgresHost => "postgres-host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectEnvResponseVariant2ContentHintVariant10Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-host" => GetProjectEnvResponseVariant2ContentHintVariant10Type.PostgresHost,
                _ => null,
            };
        }
    }
}