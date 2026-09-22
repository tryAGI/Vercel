
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of environment (production, preview, or development)
    /// </summary>
    public enum AutoSDKSharede064e44b973b9ad0Type
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
    public static class AutoSDKSharede064e44b973b9ad0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede064e44b973b9ad0Type value)
        {
            return value switch
            {
                AutoSDKSharede064e44b973b9ad0Type.Development => "development",
                AutoSDKSharede064e44b973b9ad0Type.Preview => "preview",
                AutoSDKSharede064e44b973b9ad0Type.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede064e44b973b9ad0Type? ToEnum(string value)
        {
            return value switch
            {
                "development" => AutoSDKSharede064e44b973b9ad0Type.Development,
                "preview" => AutoSDKSharede064e44b973b9ad0Type.Preview,
                "production" => AutoSDKSharede064e44b973b9ad0Type.Production,
                _ => null,
            };
        }
    }
}