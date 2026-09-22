
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfb6f42506e3e02aeVariant9Code
    {
        /// <summary>
        ///
        /// </summary>
        UnavailableLegal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfb6f42506e3e02aeVariant9CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfb6f42506e3e02aeVariant9Code value)
        {
            return value switch
            {
                AutoSDKSharedfb6f42506e3e02aeVariant9Code.UnavailableLegal => "unavailable-legal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfb6f42506e3e02aeVariant9Code? ToEnum(string value)
        {
            return value switch
            {
                "unavailable-legal" => AutoSDKSharedfb6f42506e3e02aeVariant9Code.UnavailableLegal,
                _ => null,
            };
        }
    }
}