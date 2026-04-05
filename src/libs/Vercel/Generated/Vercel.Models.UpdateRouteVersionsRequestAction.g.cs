
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateRouteVersionsRequestAction
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
    public static class UpdateRouteVersionsRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRouteVersionsRequestAction value)
        {
            return value switch
            {
                UpdateRouteVersionsRequestAction.Discard => "discard",
                UpdateRouteVersionsRequestAction.Promote => "promote",
                UpdateRouteVersionsRequestAction.Restore => "restore",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRouteVersionsRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "discard" => UpdateRouteVersionsRequestAction.Discard,
                "promote" => UpdateRouteVersionsRequestAction.Promote,
                "restore" => UpdateRouteVersionsRequestAction.Restore,
                _ => null,
            };
        }
    }
}