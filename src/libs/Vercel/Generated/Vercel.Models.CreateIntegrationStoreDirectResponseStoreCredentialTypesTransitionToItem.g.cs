
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreCredentialTypesTransitionToItem
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
    public static class CreateIntegrationStoreDirectResponseStoreCredentialTypesTransitionToItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreCredentialTypesTransitionToItem value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreCredentialTypesTransitionToItem.Oidc => "oidc",
                CreateIntegrationStoreDirectResponseStoreCredentialTypesTransitionToItem.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreCredentialTypesTransitionToItem? ToEnum(string value)
        {
            return value switch
            {
                "oidc" => CreateIntegrationStoreDirectResponseStoreCredentialTypesTransitionToItem.Oidc,
                "static" => CreateIntegrationStoreDirectResponseStoreCredentialTypesTransitionToItem.Static,
                _ => null,
            };
        }
    }
}