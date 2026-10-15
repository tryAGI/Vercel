
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd474136b05e5e447ResponseHaType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseStatus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedd474136b05e5e447ResponseHaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd474136b05e5e447ResponseHaType value)
        {
            return value switch
            {
                AutoSDKSharedd474136b05e5e447ResponseHaType.ResponseStatus => "response_status",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd474136b05e5e447ResponseHaType? ToEnum(string value)
        {
            return value switch
            {
                "response_status" => AutoSDKSharedd474136b05e5e447ResponseHaType.ResponseStatus,
                _ => null,
            };
        }
    }
}