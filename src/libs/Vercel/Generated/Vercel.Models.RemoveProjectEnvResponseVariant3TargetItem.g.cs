
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveProjectEnvResponseVariant3TargetItem
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
    public static class RemoveProjectEnvResponseVariant3TargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant3TargetItem value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant3TargetItem.Development => "development",
                RemoveProjectEnvResponseVariant3TargetItem.Preview => "preview",
                RemoveProjectEnvResponseVariant3TargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant3TargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => RemoveProjectEnvResponseVariant3TargetItem.Development,
                "preview" => RemoveProjectEnvResponseVariant3TargetItem.Preview,
                "production" => RemoveProjectEnvResponseVariant3TargetItem.Production,
                _ => null,
            };
        }
    }
}