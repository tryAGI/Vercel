
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1134f969ff3cc06cDismissedToastAction
    {
        /// <summary>
        ///
        /// </summary>
        Accept,
        /// <summary>
        ///
        /// </summary>
        Cancel,
        /// <summary>
        ///
        /// </summary>
        Delete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared1134f969ff3cc06cDismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1134f969ff3cc06cDismissedToastAction value)
        {
            return value switch
            {
                AutoSDKShared1134f969ff3cc06cDismissedToastAction.Accept => "accept",
                AutoSDKShared1134f969ff3cc06cDismissedToastAction.Cancel => "cancel",
                AutoSDKShared1134f969ff3cc06cDismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1134f969ff3cc06cDismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKShared1134f969ff3cc06cDismissedToastAction.Accept,
                "cancel" => AutoSDKShared1134f969ff3cc06cDismissedToastAction.Cancel,
                "delete" => AutoSDKShared1134f969ff3cc06cDismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}