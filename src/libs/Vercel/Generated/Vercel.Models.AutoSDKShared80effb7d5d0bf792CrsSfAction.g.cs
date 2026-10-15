
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared80effb7d5d0bf792CrsSfAction
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
    public static class AutoSDKShared80effb7d5d0bf792CrsSfActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared80effb7d5d0bf792CrsSfAction value)
        {
            return value switch
            {
                AutoSDKShared80effb7d5d0bf792CrsSfAction.Deny => "deny",
                AutoSDKShared80effb7d5d0bf792CrsSfAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared80effb7d5d0bf792CrsSfAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => AutoSDKShared80effb7d5d0bf792CrsSfAction.Deny,
                "log" => AutoSDKShared80effb7d5d0bf792CrsSfAction.Log,
                _ => null,
            };
        }
    }
}