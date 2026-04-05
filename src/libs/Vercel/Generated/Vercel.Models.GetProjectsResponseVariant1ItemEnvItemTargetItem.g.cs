
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemEnvItemTargetItem
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
    public static class GetProjectsResponseVariant1ItemEnvItemTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemEnvItemTargetItem value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemEnvItemTargetItem.Development => "development",
                GetProjectsResponseVariant1ItemEnvItemTargetItem.Preview => "preview",
                GetProjectsResponseVariant1ItemEnvItemTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemEnvItemTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetProjectsResponseVariant1ItemEnvItemTargetItem.Development,
                "preview" => GetProjectsResponseVariant1ItemEnvItemTargetItem.Preview,
                "production" => GetProjectsResponseVariant1ItemEnvItemTargetItem.Production,
                _ => null,
            };
        }
    }
}