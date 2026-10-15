
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared80effb7d5d0bf792CrsRfiAction
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
    public static class AutoSDKShared80effb7d5d0bf792CrsRfiActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared80effb7d5d0bf792CrsRfiAction value)
        {
            return value switch
            {
                AutoSDKShared80effb7d5d0bf792CrsRfiAction.Deny => "deny",
                AutoSDKShared80effb7d5d0bf792CrsRfiAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared80effb7d5d0bf792CrsRfiAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => AutoSDKShared80effb7d5d0bf792CrsRfiAction.Deny,
                "log" => AutoSDKShared80effb7d5d0bf792CrsRfiAction.Log,
                _ => null,
            };
        }
    }
}