
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of this cosmos doc instance, if blank, assume secret.<br/>
    /// Example: encrypted
    /// </summary>
    public enum AutoSDKShared3123f815641fd36dType
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
    public static class AutoSDKShared3123f815641fd36dTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared3123f815641fd36dType value)
        {
            return value switch
            {
                AutoSDKShared3123f815641fd36dType.Encrypted => "encrypted",
                AutoSDKShared3123f815641fd36dType.Plain => "plain",
                AutoSDKShared3123f815641fd36dType.Sensitive => "sensitive",
                AutoSDKShared3123f815641fd36dType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared3123f815641fd36dType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => AutoSDKShared3123f815641fd36dType.Encrypted,
                "plain" => AutoSDKShared3123f815641fd36dType.Plain,
                "sensitive" => AutoSDKShared3123f815641fd36dType.Sensitive,
                "system" => AutoSDKShared3123f815641fd36dType.System,
                _ => null,
            };
        }
    }
}