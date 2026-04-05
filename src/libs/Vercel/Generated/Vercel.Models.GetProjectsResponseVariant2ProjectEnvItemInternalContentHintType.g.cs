
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectEnvItemInternalContentHintType
    {
        /// <summary>
        /// 
        /// </summary>
        FlagsSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant2ProjectEnvItemInternalContentHintTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectEnvItemInternalContentHintType value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectEnvItemInternalContentHintType.FlagsSecret => "flags-secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectEnvItemInternalContentHintType? ToEnum(string value)
        {
            return value switch
            {
                "flags-secret" => GetProjectsResponseVariant2ProjectEnvItemInternalContentHintType.FlagsSecret,
                _ => null,
            };
        }
    }
}