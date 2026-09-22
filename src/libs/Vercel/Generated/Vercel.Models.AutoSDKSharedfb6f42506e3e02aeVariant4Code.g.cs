
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfb6f42506e3e02aeVariant4Code
    {
        /// <summary>
        ///
        /// </summary>
        IncorrectAuthCode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfb6f42506e3e02aeVariant4CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfb6f42506e3e02aeVariant4Code value)
        {
            return value switch
            {
                AutoSDKSharedfb6f42506e3e02aeVariant4Code.IncorrectAuthCode => "incorrect-auth-code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfb6f42506e3e02aeVariant4Code? ToEnum(string value)
        {
            return value switch
            {
                "incorrect-auth-code" => AutoSDKSharedfb6f42506e3e02aeVariant4Code.IncorrectAuthCode,
                _ => null,
            };
        }
    }
}