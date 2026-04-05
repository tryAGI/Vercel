
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectLinkVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectLinkVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectLinkVariant6Type value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectLinkVariant6Type.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectLinkVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "vercel" => GetMicrofrontendsInGroupResponseProjectLinkVariant6Type.Vercel,
                _ => null,
            };
        }
    }
}