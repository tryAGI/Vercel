
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared4d5a5876dd584f34DismissedToastAction
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
    public static class AutoSDKShared4d5a5876dd584f34DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared4d5a5876dd584f34DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKShared4d5a5876dd584f34DismissedToastAction.Accept => "accept",
                AutoSDKShared4d5a5876dd584f34DismissedToastAction.Cancel => "cancel",
                AutoSDKShared4d5a5876dd584f34DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared4d5a5876dd584f34DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKShared4d5a5876dd584f34DismissedToastAction.Accept,
                "cancel" => AutoSDKShared4d5a5876dd584f34DismissedToastAction.Cancel,
                "delete" => AutoSDKShared4d5a5876dd584f34DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}