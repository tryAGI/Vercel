
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Intended key use: signing or encryption.
    /// </summary>
    public enum ConnectConnectorCreateDataTypeOauthServerConfigJwksKeyUse
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
    public static class ConnectConnectorCreateDataTypeOauthServerConfigJwksKeyUseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorCreateDataTypeOauthServerConfigJwksKeyUse value)
        {
            return value switch
            {
                ConnectConnectorCreateDataTypeOauthServerConfigJwksKeyUse.Enc => "enc",
                ConnectConnectorCreateDataTypeOauthServerConfigJwksKeyUse.Sig => "sig",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorCreateDataTypeOauthServerConfigJwksKeyUse? ToEnum(string value)
        {
            return value switch
            {
                "enc" => ConnectConnectorCreateDataTypeOauthServerConfigJwksKeyUse.Enc,
                "sig" => ConnectConnectorCreateDataTypeOauthServerConfigJwksKeyUse.Sig,
                _ => null,
            };
        }
    }
}