
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectDismissedToastAction
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
    public static class GetProjectsResponseVariant3ProjectDismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectDismissedToastAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectDismissedToastAction.Accept => "accept",
                GetProjectsResponseVariant3ProjectDismissedToastAction.Cancel => "cancel",
                GetProjectsResponseVariant3ProjectDismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectDismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => GetProjectsResponseVariant3ProjectDismissedToastAction.Accept,
                "cancel" => GetProjectsResponseVariant3ProjectDismissedToastAction.Cancel,
                "delete" => GetProjectsResponseVariant3ProjectDismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}