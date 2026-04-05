
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterProjectEnvsResponseVariant1ContentHintVariant13Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresUrlNoSsl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterProjectEnvsResponseVariant1ContentHintVariant13TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant1ContentHintVariant13Type value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant1ContentHintVariant13Type.PostgresUrlNoSsl => "postgres-url-no-ssl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant1ContentHintVariant13Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-url-no-ssl" => FilterProjectEnvsResponseVariant1ContentHintVariant13Type.PostgresUrlNoSsl,
                _ => null,
            };
        }
    }
}