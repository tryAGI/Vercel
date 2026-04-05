
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The origin of this definition. 'api' means created via the API. Undefined means it originated from a deployment (vercel.json).
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectCronsDefinitionSource
    {
        /// <summary>
        /// 
        /// </summary>
        Api,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant3ProjectCronsDefinitionSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectCronsDefinitionSource value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectCronsDefinitionSource.Api => "api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectCronsDefinitionSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => GetProjectsResponseVariant3ProjectCronsDefinitionSource.Api,
                _ => null,
            };
        }
    }
}