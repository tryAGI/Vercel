
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of environment (production, preview, or development)
    /// </summary>
    public enum UpdateProjectResponseCustomEnvironmentType
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
    public static class UpdateProjectResponseCustomEnvironmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseCustomEnvironmentType value)
        {
            return value switch
            {
                UpdateProjectResponseCustomEnvironmentType.Development => "development",
                UpdateProjectResponseCustomEnvironmentType.Preview => "preview",
                UpdateProjectResponseCustomEnvironmentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseCustomEnvironmentType? ToEnum(string value)
        {
            return value switch
            {
                "development" => UpdateProjectResponseCustomEnvironmentType.Development,
                "preview" => UpdateProjectResponseCustomEnvironmentType.Preview,
                "production" => UpdateProjectResponseCustomEnvironmentType.Production,
                _ => null,
            };
        }
    }
}