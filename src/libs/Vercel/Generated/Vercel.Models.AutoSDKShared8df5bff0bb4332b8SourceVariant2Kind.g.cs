
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8df5bff0bb4332b8SourceVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared8df5bff0bb4332b8SourceVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8df5bff0bb4332b8SourceVariant2Kind value)
        {
            return value switch
            {
                AutoSDKShared8df5bff0bb4332b8SourceVariant2Kind.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8df5bff0bb4332b8SourceVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "integration" => AutoSDKShared8df5bff0bb4332b8SourceVariant2Kind.Integration,
                _ => null,
            };
        }
    }
}