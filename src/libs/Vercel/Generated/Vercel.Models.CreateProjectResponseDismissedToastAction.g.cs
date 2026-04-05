
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseDismissedToastAction
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
    public static class CreateProjectResponseDismissedToastActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseDismissedToastAction value)
        {
            return value switch
            {
                CreateProjectResponseDismissedToastAction.Accept => "accept",
                CreateProjectResponseDismissedToastAction.Cancel => "cancel",
                CreateProjectResponseDismissedToastAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseDismissedToastAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => CreateProjectResponseDismissedToastAction.Accept,
                "cancel" => CreateProjectResponseDismissedToastAction.Cancel,
                "delete" => CreateProjectResponseDismissedToastAction.Delete,
                _ => null,
            };
        }
    }
}