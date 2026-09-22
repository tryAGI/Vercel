
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7e5cde0fd7c87b94CrsRceAction
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
    public static class AutoSDKShared7e5cde0fd7c87b94CrsRceActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7e5cde0fd7c87b94CrsRceAction value)
        {
            return value switch
            {
                AutoSDKShared7e5cde0fd7c87b94CrsRceAction.Deny => "deny",
                AutoSDKShared7e5cde0fd7c87b94CrsRceAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7e5cde0fd7c87b94CrsRceAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => AutoSDKShared7e5cde0fd7c87b94CrsRceAction.Deny,
                "log" => AutoSDKShared7e5cde0fd7c87b94CrsRceAction.Log,
                _ => null,
            };
        }
    }
}