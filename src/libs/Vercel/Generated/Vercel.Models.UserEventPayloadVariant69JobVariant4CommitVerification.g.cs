
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Since 6 Nov 2025 The verification status of the commit. - 'verified' if the commit is verified - 'unverified' if the commit is not verified - 'unknown' if the commit verification status is unknown or not supported
    /// </summary>
    public enum UserEventPayloadVariant69JobVariant4CommitVerification
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
    public static class UserEventPayloadVariant69JobVariant4CommitVerificationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant69JobVariant4CommitVerification value)
        {
            return value switch
            {
                UserEventPayloadVariant69JobVariant4CommitVerification.Unknown => "unknown",
                UserEventPayloadVariant69JobVariant4CommitVerification.Unverified => "unverified",
                UserEventPayloadVariant69JobVariant4CommitVerification.Verified => "verified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant69JobVariant4CommitVerification? ToEnum(string value)
        {
            return value switch
            {
                "unknown" => UserEventPayloadVariant69JobVariant4CommitVerification.Unknown,
                "unverified" => UserEventPayloadVariant69JobVariant4CommitVerification.Unverified,
                "verified" => UserEventPayloadVariant69JobVariant4CommitVerification.Verified,
                _ => null,
            };
        }
    }
}