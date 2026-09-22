
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1ed2975831fbb888CrsSfAction
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
    public static class AutoSDKShared1ed2975831fbb888CrsSfActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1ed2975831fbb888CrsSfAction value)
        {
            return value switch
            {
                AutoSDKShared1ed2975831fbb888CrsSfAction.Deny => "deny",
                AutoSDKShared1ed2975831fbb888CrsSfAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1ed2975831fbb888CrsSfAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => AutoSDKShared1ed2975831fbb888CrsSfAction.Deny,
                "log" => AutoSDKShared1ed2975831fbb888CrsSfAction.Log,
                _ => null,
            };
        }
    }
}