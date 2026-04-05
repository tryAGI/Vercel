
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectEnvItemTarget
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
    public static class GetProjectsResponseVariant2ProjectEnvItemTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectEnvItemTarget value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectEnvItemTarget.Development => "development",
                GetProjectsResponseVariant2ProjectEnvItemTarget.Preview => "preview",
                GetProjectsResponseVariant2ProjectEnvItemTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectEnvItemTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetProjectsResponseVariant2ProjectEnvItemTarget.Development,
                "preview" => GetProjectsResponseVariant2ProjectEnvItemTarget.Preview,
                "production" => GetProjectsResponseVariant2ProjectEnvItemTarget.Production,
                _ => null,
            };
        }
    }
}