
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The origin of this definition. 'api' means created via the API. Undefined means it originated from a deployment (vercel.json).
    /// </summary>
    public enum GetProjectResponseCronsDefinitionSource
    {
        /// <summary>
        /// 
        /// </summary>
        Api,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseCronsDefinitionSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseCronsDefinitionSource value)
        {
            return value switch
            {
                GetProjectResponseCronsDefinitionSource.Api => "api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseCronsDefinitionSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => GetProjectResponseCronsDefinitionSource.Api,
                _ => null,
            };
        }
    }
}