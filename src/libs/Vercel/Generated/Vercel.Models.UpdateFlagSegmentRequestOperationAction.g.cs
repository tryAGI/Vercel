
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagSegmentRequestOperationAction
    {
        /// <summary>
        /// 
        /// </summary>
        Add,
        /// <summary>
        /// 
        /// </summary>
        Remove,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagSegmentRequestOperationActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagSegmentRequestOperationAction value)
        {
            return value switch
            {
                UpdateFlagSegmentRequestOperationAction.Add => "add",
                UpdateFlagSegmentRequestOperationAction.Remove => "remove",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagSegmentRequestOperationAction? ToEnum(string value)
        {
            return value switch
            {
                "add" => UpdateFlagSegmentRequestOperationAction.Add,
                "remove" => UpdateFlagSegmentRequestOperationAction.Remove,
                _ => null,
            };
        }
    }
}