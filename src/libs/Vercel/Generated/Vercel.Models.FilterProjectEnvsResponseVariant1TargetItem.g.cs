
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterProjectEnvsResponseVariant1TargetItem
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
    public static class FilterProjectEnvsResponseVariant1TargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant1TargetItem value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant1TargetItem.Development => "development",
                FilterProjectEnvsResponseVariant1TargetItem.Preview => "preview",
                FilterProjectEnvsResponseVariant1TargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant1TargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => FilterProjectEnvsResponseVariant1TargetItem.Development,
                "preview" => FilterProjectEnvsResponseVariant1TargetItem.Preview,
                "production" => FilterProjectEnvsResponseVariant1TargetItem.Production,
                _ => null,
            };
        }
    }
}