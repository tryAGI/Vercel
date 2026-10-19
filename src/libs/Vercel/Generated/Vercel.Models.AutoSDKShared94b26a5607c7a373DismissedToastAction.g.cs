
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared94b26a5607c7a373DismissedToastAction
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
    public static class AutoSDKShared94b26a5607c7a373DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared94b26a5607c7a373DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKShared94b26a5607c7a373DismissedToastAction.Accept => "accept",
                AutoSDKShared94b26a5607c7a373DismissedToastAction.Cancel => "cancel",
                AutoSDKShared94b26a5607c7a373DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared94b26a5607c7a373DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKShared94b26a5607c7a373DismissedToastAction.Accept,
                "cancel" => AutoSDKShared94b26a5607c7a373DismissedToastAction.Cancel,
                "delete" => AutoSDKShared94b26a5607c7a373DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}