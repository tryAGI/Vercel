
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseEnvItemTarget
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
    public static class GetProjectResponseEnvItemTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseEnvItemTarget value)
        {
            return value switch
            {
                GetProjectResponseEnvItemTarget.Development => "development",
                GetProjectResponseEnvItemTarget.Preview => "preview",
                GetProjectResponseEnvItemTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseEnvItemTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetProjectResponseEnvItemTarget.Development,
                "preview" => GetProjectResponseEnvItemTarget.Preview,
                "production" => GetProjectResponseEnvItemTarget.Production,
                _ => null,
            };
        }
    }
}