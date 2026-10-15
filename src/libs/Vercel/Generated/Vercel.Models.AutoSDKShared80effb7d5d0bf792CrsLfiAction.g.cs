
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared80effb7d5d0bf792CrsLfiAction
    {
        /// <summary>
        ///
        /// </summary>
        Deny,
        /// <summary>
        ///
        /// </summary>
        Log,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared80effb7d5d0bf792CrsLfiActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared80effb7d5d0bf792CrsLfiAction value)
        {
            return value switch
            {
                AutoSDKShared80effb7d5d0bf792CrsLfiAction.Deny => "deny",
                AutoSDKShared80effb7d5d0bf792CrsLfiAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared80effb7d5d0bf792CrsLfiAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => AutoSDKShared80effb7d5d0bf792CrsLfiAction.Deny,
                "log" => AutoSDKShared80effb7d5d0bf792CrsLfiAction.Log,
                _ => null,
            };
        }
    }
}