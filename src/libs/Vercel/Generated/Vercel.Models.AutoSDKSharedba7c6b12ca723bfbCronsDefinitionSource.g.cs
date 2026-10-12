
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The origin of this definition. 'api' means created via the API. Undefined means it originated from a deployment (vercel.json).
    /// </summary>
    public enum AutoSDKSharedba7c6b12ca723bfbCronsDefinitionSource
    {
        /// <summary>
        ///
        /// </summary>
        Api,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedba7c6b12ca723bfbCronsDefinitionSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedba7c6b12ca723bfbCronsDefinitionSource value)
        {
            return value switch
            {
                AutoSDKSharedba7c6b12ca723bfbCronsDefinitionSource.Api => "api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedba7c6b12ca723bfbCronsDefinitionSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => AutoSDKSharedba7c6b12ca723bfbCronsDefinitionSource.Api,
                _ => null,
            };
        }
    }
}