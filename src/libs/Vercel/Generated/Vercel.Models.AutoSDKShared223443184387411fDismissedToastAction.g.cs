
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared223443184387411fDismissedToastAction
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
    public static class AutoSDKShared223443184387411fDismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared223443184387411fDismissedToastAction value)
        {
            return value switch
            {
                AutoSDKShared223443184387411fDismissedToastAction.Accept => "accept",
                AutoSDKShared223443184387411fDismissedToastAction.Cancel => "cancel",
                AutoSDKShared223443184387411fDismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared223443184387411fDismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKShared223443184387411fDismissedToastAction.Accept,
                "cancel" => AutoSDKShared223443184387411fDismissedToastAction.Cancel,
                "delete" => AutoSDKShared223443184387411fDismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}