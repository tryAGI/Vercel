
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagsSdkKeyWithSecretsType
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
    public static class FlagsSdkKeyWithSecretsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagsSdkKeyWithSecretsType value)
        {
            return value switch
            {
                FlagsSdkKeyWithSecretsType.Client => "client",
                FlagsSdkKeyWithSecretsType.Mobile => "mobile",
                FlagsSdkKeyWithSecretsType.Server => "server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagsSdkKeyWithSecretsType? ToEnum(string value)
        {
            return value switch
            {
                "client" => FlagsSdkKeyWithSecretsType.Client,
                "mobile" => FlagsSdkKeyWithSecretsType.Mobile,
                "server" => FlagsSdkKeyWithSecretsType.Server,
                _ => null,
            };
        }
    }
}