
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterProjectEnvsResponseVariant3EnvTargetItem
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
    public static class FilterProjectEnvsResponseVariant3EnvTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant3EnvTargetItem value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant3EnvTargetItem.Development => "development",
                FilterProjectEnvsResponseVariant3EnvTargetItem.Preview => "preview",
                FilterProjectEnvsResponseVariant3EnvTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant3EnvTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => FilterProjectEnvsResponseVariant3EnvTargetItem.Development,
                "preview" => FilterProjectEnvsResponseVariant3EnvTargetItem.Preview,
                "production" => FilterProjectEnvsResponseVariant3EnvTargetItem.Production,
                _ => null,
            };
        }
    }
}