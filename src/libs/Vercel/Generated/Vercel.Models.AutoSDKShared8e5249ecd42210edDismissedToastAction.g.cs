
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8e5249ecd42210edDismissedToastAction
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
    public static class AutoSDKShared8e5249ecd42210edDismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8e5249ecd42210edDismissedToastAction value)
        {
            return value switch
            {
                AutoSDKShared8e5249ecd42210edDismissedToastAction.Accept => "accept",
                AutoSDKShared8e5249ecd42210edDismissedToastAction.Cancel => "cancel",
                AutoSDKShared8e5249ecd42210edDismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8e5249ecd42210edDismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKShared8e5249ecd42210edDismissedToastAction.Accept,
                "cancel" => AutoSDKShared8e5249ecd42210edDismissedToastAction.Cancel,
                "delete" => AutoSDKShared8e5249ecd42210edDismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}