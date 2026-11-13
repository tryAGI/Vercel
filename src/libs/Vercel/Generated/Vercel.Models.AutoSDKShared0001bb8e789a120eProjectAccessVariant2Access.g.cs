
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0001bb8e789a120eProjectAccessVariant2Access
    {
        /// <summary>
        ///
        /// </summary>
        Some,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0001bb8e789a120eProjectAccessVariant2AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0001bb8e789a120eProjectAccessVariant2Access value)
        {
            return value switch
            {
                AutoSDKShared0001bb8e789a120eProjectAccessVariant2Access.Some => "some",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0001bb8e789a120eProjectAccessVariant2Access? ToEnum(string value)
        {
            return value switch
            {
                "some" => AutoSDKShared0001bb8e789a120eProjectAccessVariant2Access.Some,
                _ => null,
            };
        }
    }
}