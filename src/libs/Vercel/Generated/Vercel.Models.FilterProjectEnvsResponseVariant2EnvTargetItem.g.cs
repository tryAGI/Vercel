
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterProjectEnvsResponseVariant2EnvTargetItem
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
    public static class FilterProjectEnvsResponseVariant2EnvTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant2EnvTargetItem value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant2EnvTargetItem.Development => "development",
                FilterProjectEnvsResponseVariant2EnvTargetItem.Preview => "preview",
                FilterProjectEnvsResponseVariant2EnvTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant2EnvTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => FilterProjectEnvsResponseVariant2EnvTargetItem.Development,
                "preview" => FilterProjectEnvsResponseVariant2EnvTargetItem.Preview,
                "production" => FilterProjectEnvsResponseVariant2EnvTargetItem.Production,
                _ => null,
            };
        }
    }
}