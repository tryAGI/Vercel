
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagSegmentRequestOperationField
    {
        /// <summary>
        /// 
        /// </summary>
        Exclude,
        /// <summary>
        /// 
        /// </summary>
        Include,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagSegmentRequestOperationFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagSegmentRequestOperationField value)
        {
            return value switch
            {
                UpdateFlagSegmentRequestOperationField.Exclude => "exclude",
                UpdateFlagSegmentRequestOperationField.Include => "include",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagSegmentRequestOperationField? ToEnum(string value)
        {
            return value switch
            {
                "exclude" => UpdateFlagSegmentRequestOperationField.Exclude,
                "include" => UpdateFlagSegmentRequestOperationField.Include,
                _ => null,
            };
        }
    }
}