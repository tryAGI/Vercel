
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The version of the microfrontends config schema.
    /// </summary>
    public enum GetMicrofrontendsConfigForProjectResponseConfigVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsConfigForProjectResponseConfigVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsConfigForProjectResponseConfigVersion value)
        {
            return value switch
            {
                GetMicrofrontendsConfigForProjectResponseConfigVersion.x1 => "1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsConfigForProjectResponseConfigVersion? ToEnum(string value)
        {
            return value switch
            {
                "1" => GetMicrofrontendsConfigForProjectResponseConfigVersion.x1,
                _ => null,
            };
        }
    }
}