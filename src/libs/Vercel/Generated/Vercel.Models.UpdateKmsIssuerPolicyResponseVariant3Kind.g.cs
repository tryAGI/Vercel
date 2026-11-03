
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateKmsIssuerPolicyResponseVariant3Kind
    {
        /// <summary>
        ///
        /// </summary>
        IntegrationTokensGrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateKmsIssuerPolicyResponseVariant3KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateKmsIssuerPolicyResponseVariant3Kind value)
        {
            return value switch
            {
                UpdateKmsIssuerPolicyResponseVariant3Kind.IntegrationTokensGrant => "integration-tokens-grant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateKmsIssuerPolicyResponseVariant3Kind? ToEnum(string value)
        {
            return value switch
            {
                "integration-tokens-grant" => UpdateKmsIssuerPolicyResponseVariant3Kind.IntegrationTokensGrant,
                _ => null,
            };
        }
    }
}