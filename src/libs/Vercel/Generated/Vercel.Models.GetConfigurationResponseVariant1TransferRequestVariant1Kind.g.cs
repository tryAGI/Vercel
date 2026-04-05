
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationResponseVariant1TransferRequestVariant1Kind
    {
        /// <summary>
        /// 
        /// </summary>
        TransferToMarketplace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationResponseVariant1TransferRequestVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationResponseVariant1TransferRequestVariant1Kind value)
        {
            return value switch
            {
                GetConfigurationResponseVariant1TransferRequestVariant1Kind.TransferToMarketplace => "transfer-to-marketplace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationResponseVariant1TransferRequestVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "transfer-to-marketplace" => GetConfigurationResponseVariant1TransferRequestVariant1Kind.TransferToMarketplace,
                _ => null,
            };
        }
    }
}