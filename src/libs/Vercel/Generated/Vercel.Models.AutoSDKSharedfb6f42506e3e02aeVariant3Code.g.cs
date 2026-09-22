
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfb6f42506e3e02aeVariant3Code
    {
        /// <summary>
        ///
        /// </summary>
        ClientTransferProhibited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfb6f42506e3e02aeVariant3CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfb6f42506e3e02aeVariant3Code value)
        {
            return value switch
            {
                AutoSDKSharedfb6f42506e3e02aeVariant3Code.ClientTransferProhibited => "client-transfer-prohibited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfb6f42506e3e02aeVariant3Code? ToEnum(string value)
        {
            return value switch
            {
                "client-transfer-prohibited" => AutoSDKSharedfb6f42506e3e02aeVariant3Code.ClientTransferProhibited,
                _ => null,
            };
        }
    }
}