
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectEnvResponseVariant1InternalContentHintType
    {
        /// <summary>
        /// 
        /// </summary>
        FlagsSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectEnvResponseVariant1InternalContentHintTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectEnvResponseVariant1InternalContentHintType value)
        {
            return value switch
            {
                GetProjectEnvResponseVariant1InternalContentHintType.FlagsSecret => "flags-secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectEnvResponseVariant1InternalContentHintType? ToEnum(string value)
        {
            return value switch
            {
                "flags-secret" => GetProjectEnvResponseVariant1InternalContentHintType.FlagsSecret,
                _ => null,
            };
        }
    }
}