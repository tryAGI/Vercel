
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6ed7be4e006b051dVariant3OwnerType
    {
        /// <summary>
        ///
        /// </summary>
        Team,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6ed7be4e006b051dVariant3OwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6ed7be4e006b051dVariant3OwnerType value)
        {
            return value switch
            {
                AutoSDKShared6ed7be4e006b051dVariant3OwnerType.Team => "team",
                AutoSDKShared6ed7be4e006b051dVariant3OwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6ed7be4e006b051dVariant3OwnerType? ToEnum(string value)
        {
            return value switch
            {
                "team" => AutoSDKShared6ed7be4e006b051dVariant3OwnerType.Team,
                "user" => AutoSDKShared6ed7be4e006b051dVariant3OwnerType.User,
                _ => null,
            };
        }
    }
}