
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateConnectorRequestDataTypeOauthServerConfigJwksKeyUse
    {
        /// <summary>
        /// 
        /// </summary>
        Enc,
        /// <summary>
        /// 
        /// </summary>
        Sig,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConnectorRequestDataTypeOauthServerConfigJwksKeyUseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConnectorRequestDataTypeOauthServerConfigJwksKeyUse value)
        {
            return value switch
            {
                CreateConnectorRequestDataTypeOauthServerConfigJwksKeyUse.Enc => "enc",
                CreateConnectorRequestDataTypeOauthServerConfigJwksKeyUse.Sig => "sig",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConnectorRequestDataTypeOauthServerConfigJwksKeyUse? ToEnum(string value)
        {
            return value switch
            {
                "enc" => CreateConnectorRequestDataTypeOauthServerConfigJwksKeyUse.Enc,
                "sig" => CreateConnectorRequestDataTypeOauthServerConfigJwksKeyUse.Sig,
                _ => null,
            };
        }
    }
}