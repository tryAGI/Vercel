
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7851faacb4798d73DismissedToastAction
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
    public static class AutoSDKShared7851faacb4798d73DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7851faacb4798d73DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKShared7851faacb4798d73DismissedToastAction.Accept => "accept",
                AutoSDKShared7851faacb4798d73DismissedToastAction.Cancel => "cancel",
                AutoSDKShared7851faacb4798d73DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7851faacb4798d73DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKShared7851faacb4798d73DismissedToastAction.Accept,
                "cancel" => AutoSDKShared7851faacb4798d73DismissedToastAction.Cancel,
                "delete" => AutoSDKShared7851faacb4798d73DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}