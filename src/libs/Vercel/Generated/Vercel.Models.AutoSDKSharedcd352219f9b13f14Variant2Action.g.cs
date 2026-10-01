
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedcd352219f9b13f14Variant2Action
    {
        /// <summary>
        ///
        /// </summary>
        Unblocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedcd352219f9b13f14Variant2ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedcd352219f9b13f14Variant2Action value)
        {
            return value switch
            {
                AutoSDKSharedcd352219f9b13f14Variant2Action.Unblocked => "unblocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedcd352219f9b13f14Variant2Action? ToEnum(string value)
        {
            return value switch
            {
                "unblocked" => AutoSDKSharedcd352219f9b13f14Variant2Action.Unblocked,
                _ => null,
            };
        }
    }
}