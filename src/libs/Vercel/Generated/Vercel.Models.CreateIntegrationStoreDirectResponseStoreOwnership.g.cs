
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreOwnership
    {
        /// <summary>
        /// 
        /// </summary>
        Linked,
        /// <summary>
        /// 
        /// </summary>
        Owned,
        /// <summary>
        /// 
        /// </summary>
        Sandbox,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateIntegrationStoreDirectResponseStoreOwnershipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreOwnership value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreOwnership.Linked => "linked",
                CreateIntegrationStoreDirectResponseStoreOwnership.Owned => "owned",
                CreateIntegrationStoreDirectResponseStoreOwnership.Sandbox => "sandbox",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreOwnership? ToEnum(string value)
        {
            return value switch
            {
                "linked" => CreateIntegrationStoreDirectResponseStoreOwnership.Linked,
                "owned" => CreateIntegrationStoreDirectResponseStoreOwnership.Owned,
                "sandbox" => CreateIntegrationStoreDirectResponseStoreOwnership.Sandbox,
                _ => null,
            };
        }
    }
}