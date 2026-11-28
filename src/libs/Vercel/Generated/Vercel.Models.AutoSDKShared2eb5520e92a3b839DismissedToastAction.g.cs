
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2eb5520e92a3b839DismissedToastAction
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
    public static class AutoSDKShared2eb5520e92a3b839DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2eb5520e92a3b839DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKShared2eb5520e92a3b839DismissedToastAction.Accept => "accept",
                AutoSDKShared2eb5520e92a3b839DismissedToastAction.Cancel => "cancel",
                AutoSDKShared2eb5520e92a3b839DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2eb5520e92a3b839DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKShared2eb5520e92a3b839DismissedToastAction.Accept,
                "cancel" => AutoSDKShared2eb5520e92a3b839DismissedToastAction.Cancel,
                "delete" => AutoSDKShared2eb5520e92a3b839DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}