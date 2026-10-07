
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The origin of this definition. 'api' means created via the API. Undefined means it originated from a deployment (vercel.json).
    /// </summary>
    public enum AutoSDKShared223443184387411fCronsDefinitionSource
    {
        /// <summary>
        ///
        /// </summary>
        Api,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared223443184387411fCronsDefinitionSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared223443184387411fCronsDefinitionSource value)
        {
            return value switch
            {
                AutoSDKShared223443184387411fCronsDefinitionSource.Api => "api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared223443184387411fCronsDefinitionSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => AutoSDKShared223443184387411fCronsDefinitionSource.Api,
                _ => null,
            };
        }
    }
}