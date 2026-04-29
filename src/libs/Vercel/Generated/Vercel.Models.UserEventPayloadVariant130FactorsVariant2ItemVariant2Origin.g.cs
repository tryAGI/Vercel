
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant130FactorsVariant2ItemVariant2Origin
    {
        /// <summary>
        /// 
        /// </summary>
        RecoveryCode,
        /// <summary>
        /// 
        /// </summary>
        Totp,
        /// <summary>
        /// 
        /// </summary>
        Webauthn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant130FactorsVariant2ItemVariant2OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant130FactorsVariant2ItemVariant2Origin value)
        {
            return value switch
            {
                UserEventPayloadVariant130FactorsVariant2ItemVariant2Origin.RecoveryCode => "recovery-code",
                UserEventPayloadVariant130FactorsVariant2ItemVariant2Origin.Totp => "totp",
                UserEventPayloadVariant130FactorsVariant2ItemVariant2Origin.Webauthn => "webauthn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant130FactorsVariant2ItemVariant2Origin? ToEnum(string value)
        {
            return value switch
            {
                "recovery-code" => UserEventPayloadVariant130FactorsVariant2ItemVariant2Origin.RecoveryCode,
                "totp" => UserEventPayloadVariant130FactorsVariant2ItemVariant2Origin.Totp,
                "webauthn" => UserEventPayloadVariant130FactorsVariant2ItemVariant2Origin.Webauthn,
                _ => null,
            };
        }
    }
}