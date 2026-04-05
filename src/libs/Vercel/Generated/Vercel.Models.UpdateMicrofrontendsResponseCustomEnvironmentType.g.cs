
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of environment (production, preview, or development)
    /// </summary>
    public enum UpdateMicrofrontendsResponseCustomEnvironmentType
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
    public static class UpdateMicrofrontendsResponseCustomEnvironmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseCustomEnvironmentType value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseCustomEnvironmentType.Development => "development",
                UpdateMicrofrontendsResponseCustomEnvironmentType.Preview => "preview",
                UpdateMicrofrontendsResponseCustomEnvironmentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseCustomEnvironmentType? ToEnum(string value)
        {
            return value switch
            {
                "development" => UpdateMicrofrontendsResponseCustomEnvironmentType.Development,
                "preview" => UpdateMicrofrontendsResponseCustomEnvironmentType.Preview,
                "production" => UpdateMicrofrontendsResponseCustomEnvironmentType.Production,
                _ => null,
            };
        }
    }
}