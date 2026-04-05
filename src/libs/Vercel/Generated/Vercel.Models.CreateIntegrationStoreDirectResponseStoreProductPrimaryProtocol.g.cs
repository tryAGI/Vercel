
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol
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
    public static class CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocolExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.Ai => "ai",
                CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.Authentication => "authentication",
                CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.Checks => "checks",
                CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.Experimentation => "experimentation",
                CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.LogDrain => "logDrain",
                CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.Messaging => "messaging",
                CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.Observability => "observability",
                CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.Other => "other",
                CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.Storage => "storage",
                CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.TraceDrain => "traceDrain",
                CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.Video => "video",
                CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol? ToEnum(string value)
        {
            return value switch
            {
                "ai" => CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.Ai,
                "authentication" => CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.Authentication,
                "checks" => CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.Checks,
                "experimentation" => CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.Experimentation,
                "logDrain" => CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.LogDrain,
                "messaging" => CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.Messaging,
                "observability" => CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.Observability,
                "other" => CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.Other,
                "storage" => CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.Storage,
                "traceDrain" => CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.TraceDrain,
                "video" => CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.Video,
                "workflow" => CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol.Workflow,
                _ => null,
            };
        }
    }
}