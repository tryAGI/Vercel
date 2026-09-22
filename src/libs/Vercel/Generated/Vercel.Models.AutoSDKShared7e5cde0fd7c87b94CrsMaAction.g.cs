
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7e5cde0fd7c87b94CrsMaAction
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
    public static class AutoSDKShared7e5cde0fd7c87b94CrsMaActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7e5cde0fd7c87b94CrsMaAction value)
        {
            return value switch
            {
                AutoSDKShared7e5cde0fd7c87b94CrsMaAction.Deny => "deny",
                AutoSDKShared7e5cde0fd7c87b94CrsMaAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7e5cde0fd7c87b94CrsMaAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => AutoSDKShared7e5cde0fd7c87b94CrsMaAction.Deny,
                "log" => AutoSDKShared7e5cde0fd7c87b94CrsMaAction.Log,
                _ => null,
            };
        }
    }
}