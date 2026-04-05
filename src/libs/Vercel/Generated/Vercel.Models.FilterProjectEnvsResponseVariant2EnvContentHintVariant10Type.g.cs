
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterProjectEnvsResponseVariant2EnvContentHintVariant10Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresHost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterProjectEnvsResponseVariant2EnvContentHintVariant10TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant2EnvContentHintVariant10Type value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant2EnvContentHintVariant10Type.PostgresHost => "postgres-host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant2EnvContentHintVariant10Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-host" => FilterProjectEnvsResponseVariant2EnvContentHintVariant10Type.PostgresHost,
                _ => null,
            };
        }
    }
}