
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterProjectEnvsResponseVariant3EnvContentHintVariant11Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresPassword,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterProjectEnvsResponseVariant3EnvContentHintVariant11TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant3EnvContentHintVariant11Type value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant3EnvContentHintVariant11Type.PostgresPassword => "postgres-password",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant3EnvContentHintVariant11Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-password" => FilterProjectEnvsResponseVariant3EnvContentHintVariant11Type.PostgresPassword,
                _ => null,
            };
        }
    }
}