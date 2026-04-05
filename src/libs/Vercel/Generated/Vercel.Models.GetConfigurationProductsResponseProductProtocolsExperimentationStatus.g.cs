
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationProductsResponseProductProtocolsExperimentationStatus
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
    public static class GetConfigurationProductsResponseProductProtocolsExperimentationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationProductsResponseProductProtocolsExperimentationStatus value)
        {
            return value switch
            {
                GetConfigurationProductsResponseProductProtocolsExperimentationStatus.Disabled => "disabled",
                GetConfigurationProductsResponseProductProtocolsExperimentationStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationProductsResponseProductProtocolsExperimentationStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => GetConfigurationProductsResponseProductProtocolsExperimentationStatus.Disabled,
                "enabled" => GetConfigurationProductsResponseProductProtocolsExperimentationStatus.Enabled,
                _ => null,
            };
        }
    }
}