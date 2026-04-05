
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of environment (production, preview, or development)
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectCustomEnvironmentType
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
    public static class GetMicrofrontendsInGroupResponseProjectCustomEnvironmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectCustomEnvironmentType value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectCustomEnvironmentType.Development => "development",
                GetMicrofrontendsInGroupResponseProjectCustomEnvironmentType.Preview => "preview",
                GetMicrofrontendsInGroupResponseProjectCustomEnvironmentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectCustomEnvironmentType? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetMicrofrontendsInGroupResponseProjectCustomEnvironmentType.Development,
                "preview" => GetMicrofrontendsInGroupResponseProjectCustomEnvironmentType.Preview,
                "production" => GetMicrofrontendsInGroupResponseProjectCustomEnvironmentType.Production,
                _ => null,
            };
        }
    }
}