
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc9c79e81839bbccdDismissedToastAction
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
    public static class AutoSDKSharedc9c79e81839bbccdDismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc9c79e81839bbccdDismissedToastAction value)
        {
            return value switch
            {
                AutoSDKSharedc9c79e81839bbccdDismissedToastAction.Accept => "accept",
                AutoSDKSharedc9c79e81839bbccdDismissedToastAction.Cancel => "cancel",
                AutoSDKSharedc9c79e81839bbccdDismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc9c79e81839bbccdDismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKSharedc9c79e81839bbccdDismissedToastAction.Accept,
                "cancel" => AutoSDKSharedc9c79e81839bbccdDismissedToastAction.Cancel,
                "delete" => AutoSDKSharedc9c79e81839bbccdDismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}