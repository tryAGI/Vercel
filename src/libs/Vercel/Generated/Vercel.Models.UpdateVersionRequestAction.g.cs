
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateVersionRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        Discard,
        /// <summary>
        /// 
        /// </summary>
        Promote,
        /// <summary>
        /// 
        /// </summary>
        Restore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateVersionRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateVersionRequestAction value)
        {
            return value switch
            {
                UpdateVersionRequestAction.Discard => "discard",
                UpdateVersionRequestAction.Promote => "promote",
                UpdateVersionRequestAction.Restore => "restore",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateVersionRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "discard" => UpdateVersionRequestAction.Discard,
                "promote" => UpdateVersionRequestAction.Promote,
                "restore" => UpdateVersionRequestAction.Restore,
                _ => null,
            };
        }
    }
}