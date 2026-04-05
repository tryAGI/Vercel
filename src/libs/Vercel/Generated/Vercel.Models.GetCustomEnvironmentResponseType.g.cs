
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of environment (production, preview, or development)
    /// </summary>
    public enum GetCustomEnvironmentResponseType
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
    public static class GetCustomEnvironmentResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCustomEnvironmentResponseType value)
        {
            return value switch
            {
                GetCustomEnvironmentResponseType.Development => "development",
                GetCustomEnvironmentResponseType.Preview => "preview",
                GetCustomEnvironmentResponseType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCustomEnvironmentResponseType? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetCustomEnvironmentResponseType.Development,
                "preview" => GetCustomEnvironmentResponseType.Preview,
                "production" => GetCustomEnvironmentResponseType.Production,
                _ => null,
            };
        }
    }
}