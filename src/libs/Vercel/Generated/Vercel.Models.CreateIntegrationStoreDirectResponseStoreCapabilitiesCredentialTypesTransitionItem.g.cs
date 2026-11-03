
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreCapabilitiesCredentialTypesTransitionItem
    {
        /// <summary>
        ///
        /// </summary>
        Oidc,
        /// <summary>
        ///
        /// </summary>
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateIntegrationStoreDirectResponseStoreCapabilitiesCredentialTypesTransitionItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreCapabilitiesCredentialTypesTransitionItem value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreCapabilitiesCredentialTypesTransitionItem.Oidc => "oidc",
                CreateIntegrationStoreDirectResponseStoreCapabilitiesCredentialTypesTransitionItem.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreCapabilitiesCredentialTypesTransitionItem? ToEnum(string value)
        {
            return value switch
            {
                "oidc" => CreateIntegrationStoreDirectResponseStoreCapabilitiesCredentialTypesTransitionItem.Oidc,
                "static" => CreateIntegrationStoreDirectResponseStoreCapabilitiesCredentialTypesTransitionItem.Static,
                _ => null,
            };
        }
    }
}