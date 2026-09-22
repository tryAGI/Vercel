
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared470bc56668090392InternalContentHintType
    {
        /// <summary>
        ///
        /// </summary>
        FlagsSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared470bc56668090392InternalContentHintTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared470bc56668090392InternalContentHintType value)
        {
            return value switch
            {
                AutoSDKShared470bc56668090392InternalContentHintType.FlagsSecret => "flags-secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared470bc56668090392InternalContentHintType? ToEnum(string value)
        {
            return value switch
            {
                "flags-secret" => AutoSDKShared470bc56668090392InternalContentHintType.FlagsSecret,
                _ => null,
            };
        }
    }
}