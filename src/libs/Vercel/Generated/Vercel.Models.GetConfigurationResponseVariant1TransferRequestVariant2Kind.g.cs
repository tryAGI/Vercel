
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationResponseVariant1TransferRequestVariant2Kind
    {
        /// <summary>
        /// 
        /// </summary>
        TransferFromMarketplace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationResponseVariant1TransferRequestVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationResponseVariant1TransferRequestVariant2Kind value)
        {
            return value switch
            {
                GetConfigurationResponseVariant1TransferRequestVariant2Kind.TransferFromMarketplace => "transfer-from-marketplace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationResponseVariant1TransferRequestVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "transfer-from-marketplace" => GetConfigurationResponseVariant1TransferRequestVariant2Kind.TransferFromMarketplace,
                _ => null,
            };
        }
    }
}