
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveProjectEnvResponseVariant1ItemTargetItem
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
    public static class RemoveProjectEnvResponseVariant1ItemTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant1ItemTargetItem value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant1ItemTargetItem.Development => "development",
                RemoveProjectEnvResponseVariant1ItemTargetItem.Preview => "preview",
                RemoveProjectEnvResponseVariant1ItemTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant1ItemTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => RemoveProjectEnvResponseVariant1ItemTargetItem.Development,
                "preview" => RemoveProjectEnvResponseVariant1ItemTargetItem.Preview,
                "production" => RemoveProjectEnvResponseVariant1ItemTargetItem.Production,
                _ => null,
            };
        }
    }
}