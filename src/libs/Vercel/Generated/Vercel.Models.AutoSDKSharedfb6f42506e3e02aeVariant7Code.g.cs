
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfb6f42506e3e02aeVariant7Code
    {
        /// <summary>
        ///
        /// </summary>
        AccountTransferRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfb6f42506e3e02aeVariant7CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfb6f42506e3e02aeVariant7Code value)
        {
            return value switch
            {
                AutoSDKSharedfb6f42506e3e02aeVariant7Code.AccountTransferRequired => "account-transfer-required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfb6f42506e3e02aeVariant7Code? ToEnum(string value)
        {
            return value switch
            {
                "account-transfer-required" => AutoSDKSharedfb6f42506e3e02aeVariant7Code.AccountTransferRequired,
                _ => null,
            };
        }
    }
}