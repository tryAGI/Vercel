
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveProjectEnvResponseVariant1ItemInternalContentHintType
    {
        /// <summary>
        /// 
        /// </summary>
        FlagsSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveProjectEnvResponseVariant1ItemInternalContentHintTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant1ItemInternalContentHintType value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant1ItemInternalContentHintType.FlagsSecret => "flags-secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant1ItemInternalContentHintType? ToEnum(string value)
        {
            return value switch
            {
                "flags-secret" => RemoveProjectEnvResponseVariant1ItemInternalContentHintType.FlagsSecret,
                _ => null,
            };
        }
    }
}