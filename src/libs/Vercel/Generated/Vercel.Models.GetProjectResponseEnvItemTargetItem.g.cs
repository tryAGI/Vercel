
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseEnvItemTargetItem
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
    public static class GetProjectResponseEnvItemTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseEnvItemTargetItem value)
        {
            return value switch
            {
                GetProjectResponseEnvItemTargetItem.Development => "development",
                GetProjectResponseEnvItemTargetItem.Preview => "preview",
                GetProjectResponseEnvItemTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseEnvItemTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetProjectResponseEnvItemTargetItem.Development,
                "preview" => GetProjectResponseEnvItemTargetItem.Preview,
                "production" => GetProjectResponseEnvItemTargetItem.Production,
                _ => null,
            };
        }
    }
}