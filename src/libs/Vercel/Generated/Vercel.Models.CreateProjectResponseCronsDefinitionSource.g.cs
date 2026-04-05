
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The origin of this definition. 'api' means created via the API. Undefined means it originated from a deployment (vercel.json).
    /// </summary>
    public enum CreateProjectResponseCronsDefinitionSource
    {
        /// <summary>
        /// 
        /// </summary>
        Api,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseCronsDefinitionSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseCronsDefinitionSource value)
        {
            return value switch
            {
                CreateProjectResponseCronsDefinitionSource.Api => "api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseCronsDefinitionSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => CreateProjectResponseCronsDefinitionSource.Api,
                _ => null,
            };
        }
    }
}