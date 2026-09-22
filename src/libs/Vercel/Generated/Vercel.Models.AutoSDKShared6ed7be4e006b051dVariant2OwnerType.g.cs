
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6ed7be4e006b051dVariant2OwnerType
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
    public static class AutoSDKShared6ed7be4e006b051dVariant2OwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6ed7be4e006b051dVariant2OwnerType value)
        {
            return value switch
            {
                AutoSDKShared6ed7be4e006b051dVariant2OwnerType.Team => "team",
                AutoSDKShared6ed7be4e006b051dVariant2OwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6ed7be4e006b051dVariant2OwnerType? ToEnum(string value)
        {
            return value switch
            {
                "team" => AutoSDKShared6ed7be4e006b051dVariant2OwnerType.Team,
                "user" => AutoSDKShared6ed7be4e006b051dVariant2OwnerType.User,
                _ => null,
            };
        }
    }
}