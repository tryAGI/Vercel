
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8b163ed62d2bb341DismissedToastAction
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
    public static class AutoSDKShared8b163ed62d2bb341DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8b163ed62d2bb341DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKShared8b163ed62d2bb341DismissedToastAction.Accept => "accept",
                AutoSDKShared8b163ed62d2bb341DismissedToastAction.Cancel => "cancel",
                AutoSDKShared8b163ed62d2bb341DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8b163ed62d2bb341DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKShared8b163ed62d2bb341DismissedToastAction.Accept,
                "cancel" => AutoSDKShared8b163ed62d2bb341DismissedToastAction.Cancel,
                "delete" => AutoSDKShared8b163ed62d2bb341DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}