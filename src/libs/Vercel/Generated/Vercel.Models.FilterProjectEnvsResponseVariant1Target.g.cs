
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterProjectEnvsResponseVariant1Target
    {
        /// <summary>
        /// 
        /// </summary>
        Development,
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterProjectEnvsResponseVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant1Target value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant1Target.Development => "development",
                FilterProjectEnvsResponseVariant1Target.Preview => "preview",
                FilterProjectEnvsResponseVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "development" => FilterProjectEnvsResponseVariant1Target.Development,
                "preview" => FilterProjectEnvsResponseVariant1Target.Preview,
                "production" => FilterProjectEnvsResponseVariant1Target.Production,
                _ => null,
            };
        }
    }
}