
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of environment (production, preview, or development)
    /// </summary>
    public enum GetProjectResponseCustomEnvironmentType
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
    public static class GetProjectResponseCustomEnvironmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseCustomEnvironmentType value)
        {
            return value switch
            {
                GetProjectResponseCustomEnvironmentType.Development => "development",
                GetProjectResponseCustomEnvironmentType.Preview => "preview",
                GetProjectResponseCustomEnvironmentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseCustomEnvironmentType? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetProjectResponseCustomEnvironmentType.Development,
                "preview" => GetProjectResponseCustomEnvironmentType.Preview,
                "production" => GetProjectResponseCustomEnvironmentType.Production,
                _ => null,
            };
        }
    }
}