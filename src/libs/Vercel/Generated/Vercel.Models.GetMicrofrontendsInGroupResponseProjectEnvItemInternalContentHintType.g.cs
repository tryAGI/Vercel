
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectEnvItemInternalContentHintType
    {
        /// <summary>
        /// 
        /// </summary>
        FlagsSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectEnvItemInternalContentHintTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectEnvItemInternalContentHintType value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectEnvItemInternalContentHintType.FlagsSecret => "flags-secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectEnvItemInternalContentHintType? ToEnum(string value)
        {
            return value switch
            {
                "flags-secret" => GetMicrofrontendsInGroupResponseProjectEnvItemInternalContentHintType.FlagsSecret,
                _ => null,
            };
        }
    }
}