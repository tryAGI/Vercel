
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfb6f42506e3e02aeVariant5Code
    {
        /// <summary>
        ///
        /// </summary>
        ClaimsNoticeRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfb6f42506e3e02aeVariant5CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfb6f42506e3e02aeVariant5Code value)
        {
            return value switch
            {
                AutoSDKSharedfb6f42506e3e02aeVariant5Code.ClaimsNoticeRequired => "claims-notice-required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfb6f42506e3e02aeVariant5Code? ToEnum(string value)
        {
            return value switch
            {
                "claims-notice-required" => AutoSDKSharedfb6f42506e3e02aeVariant5Code.ClaimsNoticeRequired,
                _ => null,
            };
        }
    }
}