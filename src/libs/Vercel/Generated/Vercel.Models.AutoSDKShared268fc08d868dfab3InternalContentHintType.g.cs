
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared268fc08d868dfab3InternalContentHintType
    {
        /// <summary>
        ///
        /// </summary>
        FlagsSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared268fc08d868dfab3InternalContentHintTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared268fc08d868dfab3InternalContentHintType value)
        {
            return value switch
            {
                AutoSDKShared268fc08d868dfab3InternalContentHintType.FlagsSecret => "flags-secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared268fc08d868dfab3InternalContentHintType? ToEnum(string value)
        {
            return value switch
            {
                "flags-secret" => AutoSDKShared268fc08d868dfab3InternalContentHintType.FlagsSecret,
                _ => null,
            };
        }
    }
}