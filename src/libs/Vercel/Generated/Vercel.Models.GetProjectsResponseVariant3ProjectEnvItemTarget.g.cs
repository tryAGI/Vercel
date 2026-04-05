
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectEnvItemTarget
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
    public static class GetProjectsResponseVariant3ProjectEnvItemTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectEnvItemTarget value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectEnvItemTarget.Development => "development",
                GetProjectsResponseVariant3ProjectEnvItemTarget.Preview => "preview",
                GetProjectsResponseVariant3ProjectEnvItemTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectEnvItemTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetProjectsResponseVariant3ProjectEnvItemTarget.Development,
                "preview" => GetProjectsResponseVariant3ProjectEnvItemTarget.Preview,
                "production" => GetProjectsResponseVariant3ProjectEnvItemTarget.Production,
                _ => null,
            };
        }
    }
}