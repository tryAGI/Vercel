
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Since 6 Nov 2025 The verification status of the commit. - 'verified' if the commit is verified - 'unverified' if the commit is not verified - 'unknown' if the commit verification status is unknown or not supported
    /// </summary>
    public enum UserEventPayloadVariant76JobVariant3CommitVerification
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
    public static class UserEventPayloadVariant76JobVariant3CommitVerificationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant76JobVariant3CommitVerification value)
        {
            return value switch
            {
                UserEventPayloadVariant76JobVariant3CommitVerification.Unknown => "unknown",
                UserEventPayloadVariant76JobVariant3CommitVerification.Unverified => "unverified",
                UserEventPayloadVariant76JobVariant3CommitVerification.Verified => "verified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant76JobVariant3CommitVerification? ToEnum(string value)
        {
            return value switch
            {
                "unknown" => UserEventPayloadVariant76JobVariant3CommitVerification.Unknown,
                "unverified" => UserEventPayloadVariant76JobVariant3CommitVerification.Unverified,
                "verified" => UserEventPayloadVariant76JobVariant3CommitVerification.Verified,
                _ => null,
            };
        }
    }
}