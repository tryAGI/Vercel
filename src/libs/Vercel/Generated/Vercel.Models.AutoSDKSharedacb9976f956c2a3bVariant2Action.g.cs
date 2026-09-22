
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedacb9976f956c2a3bVariant2Action
    {
        /// <summary>
        ///
        /// </summary>
        Unblocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedacb9976f956c2a3bVariant2ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedacb9976f956c2a3bVariant2Action value)
        {
            return value switch
            {
                AutoSDKSharedacb9976f956c2a3bVariant2Action.Unblocked => "unblocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedacb9976f956c2a3bVariant2Action? ToEnum(string value)
        {
            return value switch
            {
                "unblocked" => AutoSDKSharedacb9976f956c2a3bVariant2Action.Unblocked,
                _ => null,
            };
        }
    }
}