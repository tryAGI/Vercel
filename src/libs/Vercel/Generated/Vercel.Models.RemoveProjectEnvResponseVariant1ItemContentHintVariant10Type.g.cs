
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveProjectEnvResponseVariant1ItemContentHintVariant10Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresHost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveProjectEnvResponseVariant1ItemContentHintVariant10TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant1ItemContentHintVariant10Type value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant1ItemContentHintVariant10Type.PostgresHost => "postgres-host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant1ItemContentHintVariant10Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-host" => RemoveProjectEnvResponseVariant1ItemContentHintVariant10Type.PostgresHost,
                _ => null,
            };
        }
    }
}