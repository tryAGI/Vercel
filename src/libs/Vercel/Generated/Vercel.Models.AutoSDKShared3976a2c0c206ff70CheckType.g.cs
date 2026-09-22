
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The metric this check evaluates.
    /// </summary>
    public enum AutoSDKShared3976a2c0c206ff70CheckType
    {
        /// <summary>
        ///
        /// </summary>
        ErrorRate5xx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared3976a2c0c206ff70CheckTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared3976a2c0c206ff70CheckType value)
        {
            return value switch
            {
                AutoSDKShared3976a2c0c206ff70CheckType.ErrorRate5xx => "error-rate-5xx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared3976a2c0c206ff70CheckType? ToEnum(string value)
        {
            return value switch
            {
                "error-rate-5xx" => AutoSDKShared3976a2c0c206ff70CheckType.ErrorRate5xx,
                _ => null,
            };
        }
    }
}