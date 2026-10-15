
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd474136b05e5e447TransformType
    {
        /// <summary>
        ///
        /// </summary>
        RequestHeaders,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedd474136b05e5e447TransformTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd474136b05e5e447TransformType value)
        {
            return value switch
            {
                AutoSDKSharedd474136b05e5e447TransformType.RequestHeaders => "request.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd474136b05e5e447TransformType? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => AutoSDKSharedd474136b05e5e447TransformType.RequestHeaders,
                _ => null,
            };
        }
    }
}