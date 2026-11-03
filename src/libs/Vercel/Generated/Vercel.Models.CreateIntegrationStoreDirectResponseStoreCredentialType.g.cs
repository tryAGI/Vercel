
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The credential types the resource accepts: `static` for long-lived secrets, `oidc` for resource OIDC tokens.
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreCredentialType
    {
        /// <summary>
        /// `static` for long-lived secrets, `oidc` for resource OIDC tokens.
        /// </summary>
        Oidc,
        /// <summary>
        /// `static` for long-lived secrets, `oidc` for resource OIDC tokens.
        /// </summary>
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateIntegrationStoreDirectResponseStoreCredentialTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreCredentialType value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreCredentialType.Oidc => "oidc",
                CreateIntegrationStoreDirectResponseStoreCredentialType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreCredentialType? ToEnum(string value)
        {
            return value switch
            {
                "oidc" => CreateIntegrationStoreDirectResponseStoreCredentialType.Oidc,
                "static" => CreateIntegrationStoreDirectResponseStoreCredentialType.Static,
                _ => null,
            };
        }
    }
}