
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The deployment targets that this resource is available for.
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreTarget
    {
        /// <summary>
        /// 
        /// </summary>
        Development,
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateIntegrationStoreDirectResponseStoreTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreTarget value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreTarget.Development => "development",
                CreateIntegrationStoreDirectResponseStoreTarget.Preview => "preview",
                CreateIntegrationStoreDirectResponseStoreTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateIntegrationStoreDirectResponseStoreTarget.Development,
                "preview" => CreateIntegrationStoreDirectResponseStoreTarget.Preview,
                "production" => CreateIntegrationStoreDirectResponseStoreTarget.Production,
                _ => null,
            };
        }
    }
}