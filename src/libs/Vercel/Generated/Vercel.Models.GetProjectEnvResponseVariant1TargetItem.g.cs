
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectEnvResponseVariant1TargetItem
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
    public static class GetProjectEnvResponseVariant1TargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectEnvResponseVariant1TargetItem value)
        {
            return value switch
            {
                GetProjectEnvResponseVariant1TargetItem.Development => "development",
                GetProjectEnvResponseVariant1TargetItem.Preview => "preview",
                GetProjectEnvResponseVariant1TargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectEnvResponseVariant1TargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetProjectEnvResponseVariant1TargetItem.Development,
                "preview" => GetProjectEnvResponseVariant1TargetItem.Preview,
                "production" => GetProjectEnvResponseVariant1TargetItem.Production,
                _ => null,
            };
        }
    }
}