
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveProjectEnvResponseVariant3InternalContentHintType
    {
        /// <summary>
        /// 
        /// </summary>
        FlagsSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveProjectEnvResponseVariant3InternalContentHintTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant3InternalContentHintType value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant3InternalContentHintType.FlagsSecret => "flags-secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant3InternalContentHintType? ToEnum(string value)
        {
            return value switch
            {
                "flags-secret" => RemoveProjectEnvResponseVariant3InternalContentHintType.FlagsSecret,
                _ => null,
            };
        }
    }
}