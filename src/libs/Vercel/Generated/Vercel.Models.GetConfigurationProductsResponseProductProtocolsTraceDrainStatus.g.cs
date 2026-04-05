
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationProductsResponseProductProtocolsTraceDrainStatus
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
    public static class GetConfigurationProductsResponseProductProtocolsTraceDrainStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationProductsResponseProductProtocolsTraceDrainStatus value)
        {
            return value switch
            {
                GetConfigurationProductsResponseProductProtocolsTraceDrainStatus.Disabled => "disabled",
                GetConfigurationProductsResponseProductProtocolsTraceDrainStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationProductsResponseProductProtocolsTraceDrainStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => GetConfigurationProductsResponseProductProtocolsTraceDrainStatus.Disabled,
                "enabled" => GetConfigurationProductsResponseProductProtocolsTraceDrainStatus.Enabled,
                _ => null,
            };
        }
    }
}