
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of environment (production, preview, or development)
    /// </summary>
    public enum CreateProjectResponseCustomEnvironmentType
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
    public static class CreateProjectResponseCustomEnvironmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseCustomEnvironmentType value)
        {
            return value switch
            {
                CreateProjectResponseCustomEnvironmentType.Development => "development",
                CreateProjectResponseCustomEnvironmentType.Preview => "preview",
                CreateProjectResponseCustomEnvironmentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseCustomEnvironmentType? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateProjectResponseCustomEnvironmentType.Development,
                "preview" => CreateProjectResponseCustomEnvironmentType.Preview,
                "production" => CreateProjectResponseCustomEnvironmentType.Production,
                _ => null,
            };
        }
    }
}