
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagsSdkKeyType
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
    public static class FlagsSdkKeyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagsSdkKeyType value)
        {
            return value switch
            {
                FlagsSdkKeyType.Client => "client",
                FlagsSdkKeyType.Mobile => "mobile",
                FlagsSdkKeyType.Server => "server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagsSdkKeyType? ToEnum(string value)
        {
            return value switch
            {
                "client" => FlagsSdkKeyType.Client,
                "mobile" => FlagsSdkKeyType.Mobile,
                "server" => FlagsSdkKeyType.Server,
                _ => null,
            };
        }
    }
}