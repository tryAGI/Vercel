
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseEnvItemTarget
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
    public static class UpdateProjectResponseEnvItemTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseEnvItemTarget value)
        {
            return value switch
            {
                UpdateProjectResponseEnvItemTarget.Development => "development",
                UpdateProjectResponseEnvItemTarget.Preview => "preview",
                UpdateProjectResponseEnvItemTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseEnvItemTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => UpdateProjectResponseEnvItemTarget.Development,
                "preview" => UpdateProjectResponseEnvItemTarget.Preview,
                "production" => UpdateProjectResponseEnvItemTarget.Production,
                _ => null,
            };
        }
    }
}