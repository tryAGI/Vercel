
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The version of the microfrontends config schema.
    /// </summary>
    public enum GetMicrofrontendsConfigResponseConfigVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsConfigResponseConfigVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsConfigResponseConfigVersion value)
        {
            return value switch
            {
                GetMicrofrontendsConfigResponseConfigVersion.x1 => "1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsConfigResponseConfigVersion? ToEnum(string value)
        {
            return value switch
            {
                "1" => GetMicrofrontendsConfigResponseConfigVersion.x1,
                _ => null,
            };
        }
    }
}