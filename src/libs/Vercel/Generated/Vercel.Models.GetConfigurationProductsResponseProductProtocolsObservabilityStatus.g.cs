
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationProductsResponseProductProtocolsObservabilityStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationProductsResponseProductProtocolsObservabilityStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationProductsResponseProductProtocolsObservabilityStatus value)
        {
            return value switch
            {
                GetConfigurationProductsResponseProductProtocolsObservabilityStatus.Disabled => "disabled",
                GetConfigurationProductsResponseProductProtocolsObservabilityStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationProductsResponseProductProtocolsObservabilityStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => GetConfigurationProductsResponseProductProtocolsObservabilityStatus.Disabled,
                "enabled" => GetConfigurationProductsResponseProductProtocolsObservabilityStatus.Enabled,
                _ => null,
            };
        }
    }
}