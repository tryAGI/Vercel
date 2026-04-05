
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of environment (production, preview, or development)
    /// </summary>
    public enum UpdateCustomEnvironmentResponseType
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
    public static class UpdateCustomEnvironmentResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCustomEnvironmentResponseType value)
        {
            return value switch
            {
                UpdateCustomEnvironmentResponseType.Development => "development",
                UpdateCustomEnvironmentResponseType.Preview => "preview",
                UpdateCustomEnvironmentResponseType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCustomEnvironmentResponseType? ToEnum(string value)
        {
            return value switch
            {
                "development" => UpdateCustomEnvironmentResponseType.Development,
                "preview" => UpdateCustomEnvironmentResponseType.Preview,
                "production" => UpdateCustomEnvironmentResponseType.Production,
                _ => null,
            };
        }
    }
}