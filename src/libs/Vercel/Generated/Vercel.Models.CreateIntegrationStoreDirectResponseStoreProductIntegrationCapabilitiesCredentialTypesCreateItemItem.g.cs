
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilitiesCredentialTypesCreateItemItem
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
    public static class CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilitiesCredentialTypesCreateItemItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilitiesCredentialTypesCreateItemItem value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilitiesCredentialTypesCreateItemItem.Oidc => "oidc",
                CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilitiesCredentialTypesCreateItemItem.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilitiesCredentialTypesCreateItemItem? ToEnum(string value)
        {
            return value switch
            {
                "oidc" => CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilitiesCredentialTypesCreateItemItem.Oidc,
                "static" => CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilitiesCredentialTypesCreateItemItem.Static,
                _ => null,
            };
        }
    }
}