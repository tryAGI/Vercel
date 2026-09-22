
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0feeac66613930d1SourceVariant1Kind
    {
        /// <summary>
        ///
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0feeac66613930d1SourceVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0feeac66613930d1SourceVariant1Kind value)
        {
            return value switch
            {
                AutoSDKShared0feeac66613930d1SourceVariant1Kind.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0feeac66613930d1SourceVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "integration" => AutoSDKShared0feeac66613930d1SourceVariant1Kind.Integration,
                _ => null,
            };
        }
    }
}