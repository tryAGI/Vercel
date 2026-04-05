
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseEnvItemTargetItem
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
    public static class CreateProjectResponseEnvItemTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseEnvItemTargetItem value)
        {
            return value switch
            {
                CreateProjectResponseEnvItemTargetItem.Development => "development",
                CreateProjectResponseEnvItemTargetItem.Preview => "preview",
                CreateProjectResponseEnvItemTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseEnvItemTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateProjectResponseEnvItemTargetItem.Development,
                "preview" => CreateProjectResponseEnvItemTargetItem.Preview,
                "production" => CreateProjectResponseEnvItemTargetItem.Production,
                _ => null,
            };
        }
    }
}