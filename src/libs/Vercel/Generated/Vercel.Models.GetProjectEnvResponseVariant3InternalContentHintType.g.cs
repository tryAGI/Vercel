
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectEnvResponseVariant3InternalContentHintType
    {
        /// <summary>
        ///
        /// </summary>
        FlagsSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectEnvResponseVariant3InternalContentHintTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectEnvResponseVariant3InternalContentHintType value)
        {
            return value switch
            {
                GetProjectEnvResponseVariant3InternalContentHintType.FlagsSecret => "flags-secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectEnvResponseVariant3InternalContentHintType? ToEnum(string value)
        {
            return value switch
            {
                "flags-secret" => GetProjectEnvResponseVariant3InternalContentHintType.FlagsSecret,
                _ => null,
            };
        }
    }
}