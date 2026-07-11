
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectCreatorVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectCreatorVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectCreatorVariant4Type value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectCreatorVariant4Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectCreatorVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => GetMicrofrontendsInGroupResponseProjectCreatorVariant4Type.System,
                _ => null,
            };
        }
    }
}