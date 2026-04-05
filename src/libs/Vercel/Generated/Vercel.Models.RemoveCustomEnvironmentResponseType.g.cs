
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of environment (production, preview, or development)
    /// </summary>
    public enum RemoveCustomEnvironmentResponseType
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
    public static class RemoveCustomEnvironmentResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveCustomEnvironmentResponseType value)
        {
            return value switch
            {
                RemoveCustomEnvironmentResponseType.Development => "development",
                RemoveCustomEnvironmentResponseType.Preview => "preview",
                RemoveCustomEnvironmentResponseType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveCustomEnvironmentResponseType? ToEnum(string value)
        {
            return value switch
            {
                "development" => RemoveCustomEnvironmentResponseType.Development,
                "preview" => RemoveCustomEnvironmentResponseType.Preview,
                "production" => RemoveCustomEnvironmentResponseType.Production,
                _ => null,
            };
        }
    }
}