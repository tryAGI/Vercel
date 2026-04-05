
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The origin of this definition. 'api' means created via the API. Undefined means it originated from a deployment (vercel.json).
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectCronsDefinitionSource
    {
        /// <summary>
        /// 
        /// </summary>
        Api,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectCronsDefinitionSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectCronsDefinitionSource value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectCronsDefinitionSource.Api => "api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectCronsDefinitionSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => GetMicrofrontendsInGroupResponseProjectCronsDefinitionSource.Api,
                _ => null,
            };
        }
    }
}