
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbe3f0c688bc34a31DismissedToastAction
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
    public static class AutoSDKSharedbe3f0c688bc34a31DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbe3f0c688bc34a31DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKSharedbe3f0c688bc34a31DismissedToastAction.Accept => "accept",
                AutoSDKSharedbe3f0c688bc34a31DismissedToastAction.Cancel => "cancel",
                AutoSDKSharedbe3f0c688bc34a31DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbe3f0c688bc34a31DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKSharedbe3f0c688bc34a31DismissedToastAction.Accept,
                "cancel" => AutoSDKSharedbe3f0c688bc34a31DismissedToastAction.Cancel,
                "delete" => AutoSDKSharedbe3f0c688bc34a31DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}