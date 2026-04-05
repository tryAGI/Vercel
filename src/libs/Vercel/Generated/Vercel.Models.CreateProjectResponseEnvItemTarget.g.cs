
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseEnvItemTarget
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
    public static class CreateProjectResponseEnvItemTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseEnvItemTarget value)
        {
            return value switch
            {
                CreateProjectResponseEnvItemTarget.Development => "development",
                CreateProjectResponseEnvItemTarget.Preview => "preview",
                CreateProjectResponseEnvItemTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseEnvItemTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateProjectResponseEnvItemTarget.Development,
                "preview" => CreateProjectResponseEnvItemTarget.Preview,
                "production" => CreateProjectResponseEnvItemTarget.Production,
                _ => null,
            };
        }
    }
}