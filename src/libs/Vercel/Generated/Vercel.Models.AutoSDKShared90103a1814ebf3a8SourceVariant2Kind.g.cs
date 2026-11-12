
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared90103a1814ebf3a8SourceVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared90103a1814ebf3a8SourceVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared90103a1814ebf3a8SourceVariant2Kind value)
        {
            return value switch
            {
                AutoSDKShared90103a1814ebf3a8SourceVariant2Kind.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared90103a1814ebf3a8SourceVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "integration" => AutoSDKShared90103a1814ebf3a8SourceVariant2Kind.Integration,
                _ => null,
            };
        }
    }
}