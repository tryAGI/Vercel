
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of environment (production, preview, or development)
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectCustomEnvironmentType
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
    public static class GetProjectsResponseVariant3ProjectCustomEnvironmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectCustomEnvironmentType value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectCustomEnvironmentType.Development => "development",
                GetProjectsResponseVariant3ProjectCustomEnvironmentType.Preview => "preview",
                GetProjectsResponseVariant3ProjectCustomEnvironmentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectCustomEnvironmentType? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetProjectsResponseVariant3ProjectCustomEnvironmentType.Development,
                "preview" => GetProjectsResponseVariant3ProjectCustomEnvironmentType.Preview,
                "production" => GetProjectsResponseVariant3ProjectCustomEnvironmentType.Production,
                _ => null,
            };
        }
    }
}