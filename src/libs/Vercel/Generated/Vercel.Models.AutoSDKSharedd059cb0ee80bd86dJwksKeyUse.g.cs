
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Intended key use: signing or encryption.
    /// </summary>
    public enum AutoSDKSharedd059cb0ee80bd86dJwksKeyUse
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
    public static class AutoSDKSharedd059cb0ee80bd86dJwksKeyUseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd059cb0ee80bd86dJwksKeyUse value)
        {
            return value switch
            {
                AutoSDKSharedd059cb0ee80bd86dJwksKeyUse.Enc => "enc",
                AutoSDKSharedd059cb0ee80bd86dJwksKeyUse.Sig => "sig",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd059cb0ee80bd86dJwksKeyUse? ToEnum(string value)
        {
            return value switch
            {
                "enc" => AutoSDKSharedd059cb0ee80bd86dJwksKeyUse.Enc,
                "sig" => AutoSDKSharedd059cb0ee80bd86dJwksKeyUse.Sig,
                _ => null,
            };
        }
    }
}