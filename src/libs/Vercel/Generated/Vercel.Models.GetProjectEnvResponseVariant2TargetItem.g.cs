
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectEnvResponseVariant2TargetItem
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
    public static class GetProjectEnvResponseVariant2TargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectEnvResponseVariant2TargetItem value)
        {
            return value switch
            {
                GetProjectEnvResponseVariant2TargetItem.Development => "development",
                GetProjectEnvResponseVariant2TargetItem.Preview => "preview",
                GetProjectEnvResponseVariant2TargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectEnvResponseVariant2TargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetProjectEnvResponseVariant2TargetItem.Development,
                "preview" => GetProjectEnvResponseVariant2TargetItem.Preview,
                "production" => GetProjectEnvResponseVariant2TargetItem.Production,
                _ => null,
            };
        }
    }
}