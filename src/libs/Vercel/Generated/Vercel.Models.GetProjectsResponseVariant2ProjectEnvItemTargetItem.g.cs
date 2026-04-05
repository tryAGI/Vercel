
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectEnvItemTargetItem
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
    public static class GetProjectsResponseVariant2ProjectEnvItemTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectEnvItemTargetItem value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectEnvItemTargetItem.Development => "development",
                GetProjectsResponseVariant2ProjectEnvItemTargetItem.Preview => "preview",
                GetProjectsResponseVariant2ProjectEnvItemTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectEnvItemTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetProjectsResponseVariant2ProjectEnvItemTargetItem.Development,
                "preview" => GetProjectsResponseVariant2ProjectEnvItemTargetItem.Preview,
                "production" => GetProjectsResponseVariant2ProjectEnvItemTargetItem.Production,
                _ => null,
            };
        }
    }
}