
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationProductsResponseProductPrimaryProtocol
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
    public static class GetConfigurationProductsResponseProductPrimaryProtocolExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationProductsResponseProductPrimaryProtocol value)
        {
            return value switch
            {
                GetConfigurationProductsResponseProductPrimaryProtocol.Ai => "ai",
                GetConfigurationProductsResponseProductPrimaryProtocol.Authentication => "authentication",
                GetConfigurationProductsResponseProductPrimaryProtocol.Checks => "checks",
                GetConfigurationProductsResponseProductPrimaryProtocol.Experimentation => "experimentation",
                GetConfigurationProductsResponseProductPrimaryProtocol.LogDrain => "logDrain",
                GetConfigurationProductsResponseProductPrimaryProtocol.Messaging => "messaging",
                GetConfigurationProductsResponseProductPrimaryProtocol.Observability => "observability",
                GetConfigurationProductsResponseProductPrimaryProtocol.Other => "other",
                GetConfigurationProductsResponseProductPrimaryProtocol.Storage => "storage",
                GetConfigurationProductsResponseProductPrimaryProtocol.TraceDrain => "traceDrain",
                GetConfigurationProductsResponseProductPrimaryProtocol.Video => "video",
                GetConfigurationProductsResponseProductPrimaryProtocol.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationProductsResponseProductPrimaryProtocol? ToEnum(string value)
        {
            return value switch
            {
                "ai" => GetConfigurationProductsResponseProductPrimaryProtocol.Ai,
                "authentication" => GetConfigurationProductsResponseProductPrimaryProtocol.Authentication,
                "checks" => GetConfigurationProductsResponseProductPrimaryProtocol.Checks,
                "experimentation" => GetConfigurationProductsResponseProductPrimaryProtocol.Experimentation,
                "logDrain" => GetConfigurationProductsResponseProductPrimaryProtocol.LogDrain,
                "messaging" => GetConfigurationProductsResponseProductPrimaryProtocol.Messaging,
                "observability" => GetConfigurationProductsResponseProductPrimaryProtocol.Observability,
                "other" => GetConfigurationProductsResponseProductPrimaryProtocol.Other,
                "storage" => GetConfigurationProductsResponseProductPrimaryProtocol.Storage,
                "traceDrain" => GetConfigurationProductsResponseProductPrimaryProtocol.TraceDrain,
                "video" => GetConfigurationProductsResponseProductPrimaryProtocol.Video,
                "workflow" => GetConfigurationProductsResponseProductPrimaryProtocol.Workflow,
                _ => null,
            };
        }
    }
}