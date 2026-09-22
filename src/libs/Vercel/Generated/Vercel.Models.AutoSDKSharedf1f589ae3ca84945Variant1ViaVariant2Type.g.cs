
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf1f589ae3ca84945Variant1ViaVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedf1f589ae3ca84945Variant1ViaVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf1f589ae3ca84945Variant1ViaVariant2Type value)
        {
            return value switch
            {
                AutoSDKSharedf1f589ae3ca84945Variant1ViaVariant2Type.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf1f589ae3ca84945Variant1ViaVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "integration" => AutoSDKSharedf1f589ae3ca84945Variant1ViaVariant2Type.Integration,
                _ => null,
            };
        }
    }
}