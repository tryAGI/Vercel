
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Since 6 Nov 2025 The verification status of the commit. - 'verified' if the commit is verified - 'unverified' if the commit is not verified - 'unknown' if the commit verification status is unknown or not supported
    /// </summary>
    public enum UserEventPayloadVariant70JobVariant3CommitVerification
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        Unverified,
        /// <summary>
        /// 
        /// </summary>
        Verified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant70JobVariant3CommitVerificationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant70JobVariant3CommitVerification value)
        {
            return value switch
            {
                UserEventPayloadVariant70JobVariant3CommitVerification.Unknown => "unknown",
                UserEventPayloadVariant70JobVariant3CommitVerification.Unverified => "unverified",
                UserEventPayloadVariant70JobVariant3CommitVerification.Verified => "verified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant70JobVariant3CommitVerification? ToEnum(string value)
        {
            return value switch
            {
                "unknown" => UserEventPayloadVariant70JobVariant3CommitVerification.Unknown,
                "unverified" => UserEventPayloadVariant70JobVariant3CommitVerification.Unverified,
                "verified" => UserEventPayloadVariant70JobVariant3CommitVerification.Verified,
                _ => null,
            };
        }
    }
}