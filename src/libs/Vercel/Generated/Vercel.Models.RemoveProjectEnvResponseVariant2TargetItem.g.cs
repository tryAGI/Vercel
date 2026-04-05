
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveProjectEnvResponseVariant2TargetItem
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
    public static class RemoveProjectEnvResponseVariant2TargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant2TargetItem value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant2TargetItem.Development => "development",
                RemoveProjectEnvResponseVariant2TargetItem.Preview => "preview",
                RemoveProjectEnvResponseVariant2TargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant2TargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => RemoveProjectEnvResponseVariant2TargetItem.Development,
                "preview" => RemoveProjectEnvResponseVariant2TargetItem.Preview,
                "production" => RemoveProjectEnvResponseVariant2TargetItem.Production,
                _ => null,
            };
        }
    }
}