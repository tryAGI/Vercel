
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Since 6 Nov 2025 The verification status of the commit. - 'verified' if the commit is verified - 'unverified' if the commit is not verified - 'unknown' if the commit verification status is unknown or not supported
    /// </summary>
    public enum UserEventPayloadVariant70JobVariant6CommitVerification
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
    public static class UserEventPayloadVariant70JobVariant6CommitVerificationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant70JobVariant6CommitVerification value)
        {
            return value switch
            {
                UserEventPayloadVariant70JobVariant6CommitVerification.Unknown => "unknown",
                UserEventPayloadVariant70JobVariant6CommitVerification.Unverified => "unverified",
                UserEventPayloadVariant70JobVariant6CommitVerification.Verified => "verified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant70JobVariant6CommitVerification? ToEnum(string value)
        {
            return value switch
            {
                "unknown" => UserEventPayloadVariant70JobVariant6CommitVerification.Unknown,
                "unverified" => UserEventPayloadVariant70JobVariant6CommitVerification.Unverified,
                "verified" => UserEventPayloadVariant70JobVariant6CommitVerification.Verified,
                _ => null,
            };
        }
    }
}