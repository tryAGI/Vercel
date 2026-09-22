
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared268fc08d868dfab3Type
    {
        /// <summary>
        ///
        /// </summary>
        Encrypted,
        /// <summary>
        ///
        /// </summary>
        Plain,
        /// <summary>
        ///
        /// </summary>
        Secret,
        /// <summary>
        ///
        /// </summary>
        Sensitive,
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared268fc08d868dfab3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared268fc08d868dfab3Type value)
        {
            return value switch
            {
                AutoSDKShared268fc08d868dfab3Type.Encrypted => "encrypted",
                AutoSDKShared268fc08d868dfab3Type.Plain => "plain",
                AutoSDKShared268fc08d868dfab3Type.Secret => "secret",
                AutoSDKShared268fc08d868dfab3Type.Sensitive => "sensitive",
                AutoSDKShared268fc08d868dfab3Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared268fc08d868dfab3Type? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => AutoSDKShared268fc08d868dfab3Type.Encrypted,
                "plain" => AutoSDKShared268fc08d868dfab3Type.Plain,
                "secret" => AutoSDKShared268fc08d868dfab3Type.Secret,
                "sensitive" => AutoSDKShared268fc08d868dfab3Type.Sensitive,
                "system" => AutoSDKShared268fc08d868dfab3Type.System,
                _ => null,
            };
        }
    }
}