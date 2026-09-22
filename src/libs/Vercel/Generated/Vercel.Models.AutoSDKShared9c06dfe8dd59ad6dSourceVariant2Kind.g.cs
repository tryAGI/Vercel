
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9c06dfe8dd59ad6dSourceVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared9c06dfe8dd59ad6dSourceVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9c06dfe8dd59ad6dSourceVariant2Kind value)
        {
            return value switch
            {
                AutoSDKShared9c06dfe8dd59ad6dSourceVariant2Kind.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9c06dfe8dd59ad6dSourceVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "integration" => AutoSDKShared9c06dfe8dd59ad6dSourceVariant2Kind.Integration,
                _ => null,
            };
        }
    }
}