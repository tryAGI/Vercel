
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of this cosmos doc instance, if blank, assume secret.<br/>
    /// Example: encrypted
    /// </summary>
    public enum AutoSDKShared2e531c6dd7d2b280Type
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
        Sensitive,
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2e531c6dd7d2b280TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2e531c6dd7d2b280Type value)
        {
            return value switch
            {
                AutoSDKShared2e531c6dd7d2b280Type.Encrypted => "encrypted",
                AutoSDKShared2e531c6dd7d2b280Type.Plain => "plain",
                AutoSDKShared2e531c6dd7d2b280Type.Sensitive => "sensitive",
                AutoSDKShared2e531c6dd7d2b280Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2e531c6dd7d2b280Type? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => AutoSDKShared2e531c6dd7d2b280Type.Encrypted,
                "plain" => AutoSDKShared2e531c6dd7d2b280Type.Plain,
                "sensitive" => AutoSDKShared2e531c6dd7d2b280Type.Sensitive,
                "system" => AutoSDKShared2e531c6dd7d2b280Type.System,
                _ => null,
            };
        }
    }
}