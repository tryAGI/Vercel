
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared429ed81b15078f20DismissedToastAction
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
    public static class AutoSDKShared429ed81b15078f20DismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared429ed81b15078f20DismissedToastAction value)
        {
            return value switch
            {
                AutoSDKShared429ed81b15078f20DismissedToastAction.Accept => "accept",
                AutoSDKShared429ed81b15078f20DismissedToastAction.Cancel => "cancel",
                AutoSDKShared429ed81b15078f20DismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared429ed81b15078f20DismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => AutoSDKShared429ed81b15078f20DismissedToastAction.Accept,
                "cancel" => AutoSDKShared429ed81b15078f20DismissedToastAction.Cancel,
                "delete" => AutoSDKShared429ed81b15078f20DismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}