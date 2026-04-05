
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterProjectEnvsResponseVariant1ContentHintVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        PostgresUrlNonPooling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterProjectEnvsResponseVariant1ContentHintVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant1ContentHintVariant7Type value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant1ContentHintVariant7Type.PostgresUrlNonPooling => "postgres-url-non-pooling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant1ContentHintVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "postgres-url-non-pooling" => FilterProjectEnvsResponseVariant1ContentHintVariant7Type.PostgresUrlNonPooling,
                _ => null,
            };
        }
    }
}