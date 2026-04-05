
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol
    {
        /// <summary>
        /// 
        /// </summary>
        Ai,
        /// <summary>
        /// 
        /// </summary>
        Authentication,
        /// <summary>
        /// 
        /// </summary>
        Checks,
        /// <summary>
        /// 
        /// </summary>
        Experimentation,
        /// <summary>
        /// 
        /// </summary>
        LogDrain,
        /// <summary>
        /// 
        /// </summary>
        Messaging,
        /// <summary>
        /// 
        /// </summary>
        Observability,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        Storage,
        /// <summary>
        /// 
        /// </summary>
        TraceDrain,
        /// <summary>
        /// 
        /// </summary>
        Video,
        /// <summary>
        /// 
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateIntegrationStoreDirectResponseStoreProductSupportedProtocolExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.Ai => "ai",
                CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.Authentication => "authentication",
                CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.Checks => "checks",
                CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.Experimentation => "experimentation",
                CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.LogDrain => "logDrain",
                CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.Messaging => "messaging",
                CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.Observability => "observability",
                CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.Other => "other",
                CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.Storage => "storage",
                CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.TraceDrain => "traceDrain",
                CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.Video => "video",
                CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol? ToEnum(string value)
        {
            return value switch
            {
                "ai" => CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.Ai,
                "authentication" => CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.Authentication,
                "checks" => CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.Checks,
                "experimentation" => CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.Experimentation,
                "logDrain" => CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.LogDrain,
                "messaging" => CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.Messaging,
                "observability" => CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.Observability,
                "other" => CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.Other,
                "storage" => CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.Storage,
                "traceDrain" => CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.TraceDrain,
                "video" => CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.Video,
                "workflow" => CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol.Workflow,
                _ => null,
            };
        }
    }
}