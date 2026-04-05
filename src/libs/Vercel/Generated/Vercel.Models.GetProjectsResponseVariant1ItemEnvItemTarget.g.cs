
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemEnvItemTarget
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
    public static class GetProjectsResponseVariant1ItemEnvItemTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemEnvItemTarget value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemEnvItemTarget.Development => "development",
                GetProjectsResponseVariant1ItemEnvItemTarget.Preview => "preview",
                GetProjectsResponseVariant1ItemEnvItemTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemEnvItemTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetProjectsResponseVariant1ItemEnvItemTarget.Development,
                "preview" => GetProjectsResponseVariant1ItemEnvItemTarget.Preview,
                "production" => GetProjectsResponseVariant1ItemEnvItemTarget.Production,
                _ => null,
            };
        }
    }
}