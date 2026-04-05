
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationProductsResponseProductProtocolsWorkflowStatus
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
    public static class GetConfigurationProductsResponseProductProtocolsWorkflowStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationProductsResponseProductProtocolsWorkflowStatus value)
        {
            return value switch
            {
                GetConfigurationProductsResponseProductProtocolsWorkflowStatus.Disabled => "disabled",
                GetConfigurationProductsResponseProductProtocolsWorkflowStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationProductsResponseProductProtocolsWorkflowStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => GetConfigurationProductsResponseProductProtocolsWorkflowStatus.Disabled,
                "enabled" => GetConfigurationProductsResponseProductProtocolsWorkflowStatus.Enabled,
                _ => null,
            };
        }
    }
}