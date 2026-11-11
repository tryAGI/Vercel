
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The origin of this definition. 'api' means created via the API. Undefined means it originated from a deployment (vercel.json).
    /// </summary>
    public enum AutoSDKShared4d5a5876dd584f34CronsDefinitionSource
    {
        /// <summary>
        ///
        /// </summary>
        Api,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared4d5a5876dd584f34CronsDefinitionSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared4d5a5876dd584f34CronsDefinitionSource value)
        {
            return value switch
            {
                AutoSDKShared4d5a5876dd584f34CronsDefinitionSource.Api => "api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared4d5a5876dd584f34CronsDefinitionSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => AutoSDKShared4d5a5876dd584f34CronsDefinitionSource.Api,
                _ => null,
            };
        }
    }
}