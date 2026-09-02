
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Intended key use: signing or encryption.
    /// </summary>
    public enum ConnectConnectorUpdateDataTypeOauthServerConfigJwksKeyUse
    {
        /// <summary>
        /// signing or encryption.
        /// </summary>
        Enc,
        /// <summary>
        /// signing or encryption.
        /// </summary>
        Sig,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectConnectorUpdateDataTypeOauthServerConfigJwksKeyUseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorUpdateDataTypeOauthServerConfigJwksKeyUse value)
        {
            return value switch
            {
                ConnectConnectorUpdateDataTypeOauthServerConfigJwksKeyUse.Enc => "enc",
                ConnectConnectorUpdateDataTypeOauthServerConfigJwksKeyUse.Sig => "sig",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorUpdateDataTypeOauthServerConfigJwksKeyUse? ToEnum(string value)
        {
            return value switch
            {
                "enc" => ConnectConnectorUpdateDataTypeOauthServerConfigJwksKeyUse.Enc,
                "sig" => ConnectConnectorUpdateDataTypeOauthServerConfigJwksKeyUse.Sig,
                _ => null,
            };
        }
    }
}