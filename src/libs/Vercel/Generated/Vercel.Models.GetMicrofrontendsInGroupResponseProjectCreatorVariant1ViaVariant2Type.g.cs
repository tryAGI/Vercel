
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectCreatorVariant1ViaVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectCreatorVariant1ViaVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectCreatorVariant1ViaVariant2Type value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectCreatorVariant1ViaVariant2Type.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectCreatorVariant1ViaVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "integration" => GetMicrofrontendsInGroupResponseProjectCreatorVariant1ViaVariant2Type.Integration,
                _ => null,
            };
        }
    }
}