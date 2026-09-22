
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc396e89a7a8d84fbSourceVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedc396e89a7a8d84fbSourceVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc396e89a7a8d84fbSourceVariant2Kind value)
        {
            return value switch
            {
                AutoSDKSharedc396e89a7a8d84fbSourceVariant2Kind.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc396e89a7a8d84fbSourceVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "integration" => AutoSDKSharedc396e89a7a8d84fbSourceVariant2Kind.Integration,
                _ => null,
            };
        }
    }
}