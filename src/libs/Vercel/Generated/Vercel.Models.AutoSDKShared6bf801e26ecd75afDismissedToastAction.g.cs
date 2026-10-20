
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bf801e26ecd75afDismissedToastAction
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
    public static class AutoSDKShared6bf801e26ecd75afDismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bf801e26ecd75afDismissedToastAction value)
        {
            return value switch
            {
                AutoSDKShared6bf801e26ecd75afDismissedToastAction.Accept => "accept",
                AutoSDKShared6bf801e26ecd75afDismissedToastAction.Cancel => "cancel",
                AutoSDKShared6bf801e26ecd75afDismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bf801e26ecd75afDismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKShared6bf801e26ecd75afDismissedToastAction.Accept,
                "cancel" => AutoSDKShared6bf801e26ecd75afDismissedToastAction.Cancel,
                "delete" => AutoSDKShared6bf801e26ecd75afDismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}