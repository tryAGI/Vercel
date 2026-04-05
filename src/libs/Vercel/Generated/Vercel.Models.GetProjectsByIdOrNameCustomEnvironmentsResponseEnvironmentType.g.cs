
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of environment (production, preview, or development)
    /// </summary>
    public enum GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentType
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
    public static class GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentType value)
        {
            return value switch
            {
                GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentType.Development => "development",
                GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentType.Preview => "preview",
                GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentType? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentType.Development,
                "preview" => GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentType.Preview,
                "production" => GetProjectsByIdOrNameCustomEnvironmentsResponseEnvironmentType.Production,
                _ => null,
            };
        }
    }
}