
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectLinkVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectLinkVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectLinkVariant4Type value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectLinkVariant4Type.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectLinkVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "gitlab" => GetMicrofrontendsInGroupResponseProjectLinkVariant4Type.Gitlab,
                _ => null,
            };
        }
    }
}