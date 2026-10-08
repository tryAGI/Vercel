
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede870b907cc1fb37eDismissedToastAction
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
    public static class AutoSDKSharede870b907cc1fb37eDismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede870b907cc1fb37eDismissedToastAction value)
        {
            return value switch
            {
                AutoSDKSharede870b907cc1fb37eDismissedToastAction.Accept => "accept",
                AutoSDKSharede870b907cc1fb37eDismissedToastAction.Cancel => "cancel",
                AutoSDKSharede870b907cc1fb37eDismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede870b907cc1fb37eDismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKSharede870b907cc1fb37eDismissedToastAction.Accept,
                "cancel" => AutoSDKSharede870b907cc1fb37eDismissedToastAction.Cancel,
                "delete" => AutoSDKSharede870b907cc1fb37eDismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}