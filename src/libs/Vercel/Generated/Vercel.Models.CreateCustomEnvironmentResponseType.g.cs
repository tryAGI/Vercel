
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of environment (production, preview, or development)
    /// </summary>
    public enum CreateCustomEnvironmentResponseType
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
    public static class CreateCustomEnvironmentResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCustomEnvironmentResponseType value)
        {
            return value switch
            {
                CreateCustomEnvironmentResponseType.Development => "development",
                CreateCustomEnvironmentResponseType.Preview => "preview",
                CreateCustomEnvironmentResponseType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCustomEnvironmentResponseType? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateCustomEnvironmentResponseType.Development,
                "preview" => CreateCustomEnvironmentResponseType.Preview,
                "production" => CreateCustomEnvironmentResponseType.Production,
                _ => null,
            };
        }
    }
}