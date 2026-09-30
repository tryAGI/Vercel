
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Intended key use: signing or encryption.
    /// </summary>
    public enum AutoSDKShared448ea965c003fe05JwksKeyUse
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
    public static class AutoSDKShared448ea965c003fe05JwksKeyUseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared448ea965c003fe05JwksKeyUse value)
        {
            return value switch
            {
                AutoSDKShared448ea965c003fe05JwksKeyUse.Enc => "enc",
                AutoSDKShared448ea965c003fe05JwksKeyUse.Sig => "sig",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared448ea965c003fe05JwksKeyUse? ToEnum(string value)
        {
            return value switch
            {
                "enc" => AutoSDKShared448ea965c003fe05JwksKeyUse.Enc,
                "sig" => AutoSDKShared448ea965c003fe05JwksKeyUse.Sig,
                _ => null,
            };
        }
    }
}