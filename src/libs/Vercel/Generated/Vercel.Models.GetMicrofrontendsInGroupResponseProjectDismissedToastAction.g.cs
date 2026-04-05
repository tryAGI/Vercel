
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectDismissedToastAction
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
    public static class GetMicrofrontendsInGroupResponseProjectDismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectDismissedToastAction value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectDismissedToastAction.Accept => "accept",
                GetMicrofrontendsInGroupResponseProjectDismissedToastAction.Cancel => "cancel",
                GetMicrofrontendsInGroupResponseProjectDismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectDismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => GetMicrofrontendsInGroupResponseProjectDismissedToastAction.Accept,
                "cancel" => GetMicrofrontendsInGroupResponseProjectDismissedToastAction.Cancel,
                "delete" => GetMicrofrontendsInGroupResponseProjectDismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}