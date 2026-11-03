
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbfe68caea048321bDismissedToastAction
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
    public static class AutoSDKSharedbfe68caea048321bDismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbfe68caea048321bDismissedToastAction value)
        {
            return value switch
            {
                AutoSDKSharedbfe68caea048321bDismissedToastAction.Accept => "accept",
                AutoSDKSharedbfe68caea048321bDismissedToastAction.Cancel => "cancel",
                AutoSDKSharedbfe68caea048321bDismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbfe68caea048321bDismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKSharedbfe68caea048321bDismissedToastAction.Accept,
                "cancel" => AutoSDKSharedbfe68caea048321bDismissedToastAction.Cancel,
                "delete" => AutoSDKSharedbfe68caea048321bDismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}