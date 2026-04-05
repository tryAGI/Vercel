
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterProjectEnvsResponseVariant2EnvInternalContentHintType
    {
        /// <summary>
        /// 
        /// </summary>
        FlagsSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterProjectEnvsResponseVariant2EnvInternalContentHintTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant2EnvInternalContentHintType value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant2EnvInternalContentHintType.FlagsSecret => "flags-secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant2EnvInternalContentHintType? ToEnum(string value)
        {
            return value switch
            {
                "flags-secret" => FilterProjectEnvsResponseVariant2EnvInternalContentHintType.FlagsSecret,
                _ => null,
            };
        }
    }
}