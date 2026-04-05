
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationProductsResponseProductProtocolsAiStatus
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
    public static class GetConfigurationProductsResponseProductProtocolsAiStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationProductsResponseProductProtocolsAiStatus value)
        {
            return value switch
            {
                GetConfigurationProductsResponseProductProtocolsAiStatus.Disabled => "disabled",
                GetConfigurationProductsResponseProductProtocolsAiStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationProductsResponseProductProtocolsAiStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => GetConfigurationProductsResponseProductProtocolsAiStatus.Disabled,
                "enabled" => GetConfigurationProductsResponseProductProtocolsAiStatus.Enabled,
                _ => null,
            };
        }
    }
}