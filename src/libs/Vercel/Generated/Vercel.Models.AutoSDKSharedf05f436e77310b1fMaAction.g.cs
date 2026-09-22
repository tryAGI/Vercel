
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf05f436e77310b1fMaAction
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
    public static class AutoSDKSharedf05f436e77310b1fMaActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf05f436e77310b1fMaAction value)
        {
            return value switch
            {
                AutoSDKSharedf05f436e77310b1fMaAction.Deny => "deny",
                AutoSDKSharedf05f436e77310b1fMaAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf05f436e77310b1fMaAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => AutoSDKSharedf05f436e77310b1fMaAction.Deny,
                "log" => AutoSDKSharedf05f436e77310b1fMaAction.Log,
                _ => null,
            };
        }
    }
}