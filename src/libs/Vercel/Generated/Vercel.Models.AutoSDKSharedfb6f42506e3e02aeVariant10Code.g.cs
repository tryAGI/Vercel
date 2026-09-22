
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfb6f42506e3e02aeVariant10Code
    {
        /// <summary>
        ///
        /// </summary>
        InvalidContact,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfb6f42506e3e02aeVariant10CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfb6f42506e3e02aeVariant10Code value)
        {
            return value switch
            {
                AutoSDKSharedfb6f42506e3e02aeVariant10Code.InvalidContact => "invalid-contact",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfb6f42506e3e02aeVariant10Code? ToEnum(string value)
        {
            return value switch
            {
                "invalid-contact" => AutoSDKSharedfb6f42506e3e02aeVariant10Code.InvalidContact,
                _ => null,
            };
        }
    }
}