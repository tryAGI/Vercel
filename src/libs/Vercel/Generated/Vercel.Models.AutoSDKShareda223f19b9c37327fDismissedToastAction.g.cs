
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda223f19b9c37327fDismissedToastAction
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
    public static class AutoSDKShareda223f19b9c37327fDismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda223f19b9c37327fDismissedToastAction value)
        {
            return value switch
            {
                AutoSDKShareda223f19b9c37327fDismissedToastAction.Accept => "accept",
                AutoSDKShareda223f19b9c37327fDismissedToastAction.Cancel => "cancel",
                AutoSDKShareda223f19b9c37327fDismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda223f19b9c37327fDismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKShareda223f19b9c37327fDismissedToastAction.Accept,
                "cancel" => AutoSDKShareda223f19b9c37327fDismissedToastAction.Cancel,
                "delete" => AutoSDKShareda223f19b9c37327fDismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}