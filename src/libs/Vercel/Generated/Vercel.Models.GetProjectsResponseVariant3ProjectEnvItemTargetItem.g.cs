
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectEnvItemTargetItem
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
    public static class GetProjectsResponseVariant3ProjectEnvItemTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectEnvItemTargetItem value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectEnvItemTargetItem.Development => "development",
                GetProjectsResponseVariant3ProjectEnvItemTargetItem.Preview => "preview",
                GetProjectsResponseVariant3ProjectEnvItemTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectEnvItemTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetProjectsResponseVariant3ProjectEnvItemTargetItem.Development,
                "preview" => GetProjectsResponseVariant3ProjectEnvItemTargetItem.Preview,
                "production" => GetProjectsResponseVariant3ProjectEnvItemTargetItem.Production,
                _ => null,
            };
        }
    }
}