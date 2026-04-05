
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSdkKeyRequestSdkKeyType
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
    public static class CreateSdkKeyRequestSdkKeyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSdkKeyRequestSdkKeyType value)
        {
            return value switch
            {
                CreateSdkKeyRequestSdkKeyType.Client => "client",
                CreateSdkKeyRequestSdkKeyType.Mobile => "mobile",
                CreateSdkKeyRequestSdkKeyType.Server => "server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSdkKeyRequestSdkKeyType? ToEnum(string value)
        {
            return value switch
            {
                "client" => CreateSdkKeyRequestSdkKeyType.Client,
                "mobile" => CreateSdkKeyRequestSdkKeyType.Mobile,
                "server" => CreateSdkKeyRequestSdkKeyType.Server,
                _ => null,
            };
        }
    }
}