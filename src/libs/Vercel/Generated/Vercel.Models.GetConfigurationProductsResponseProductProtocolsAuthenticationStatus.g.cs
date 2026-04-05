
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationProductsResponseProductProtocolsAuthenticationStatus
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
    public static class GetConfigurationProductsResponseProductProtocolsAuthenticationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationProductsResponseProductProtocolsAuthenticationStatus value)
        {
            return value switch
            {
                GetConfigurationProductsResponseProductProtocolsAuthenticationStatus.Disabled => "disabled",
                GetConfigurationProductsResponseProductProtocolsAuthenticationStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationProductsResponseProductProtocolsAuthenticationStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => GetConfigurationProductsResponseProductProtocolsAuthenticationStatus.Disabled,
                "enabled" => GetConfigurationProductsResponseProductProtocolsAuthenticationStatus.Enabled,
                _ => null,
            };
        }
    }
}