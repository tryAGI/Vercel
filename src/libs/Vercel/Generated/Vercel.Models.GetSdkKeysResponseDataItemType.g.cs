
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSdkKeysResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Client,
        /// <summary>
        ///
        /// </summary>
        Mobile,
        /// <summary>
        ///
        /// </summary>
        Server,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSdkKeysResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSdkKeysResponseDataItemType value)
        {
            return value switch
            {
                GetSdkKeysResponseDataItemType.Client => "client",
                GetSdkKeysResponseDataItemType.Mobile => "mobile",
                GetSdkKeysResponseDataItemType.Server => "server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSdkKeysResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "client" => GetSdkKeysResponseDataItemType.Client,
                "mobile" => GetSdkKeysResponseDataItemType.Mobile,
                "server" => GetSdkKeysResponseDataItemType.Server,
                _ => null,
            };
        }
    }
}