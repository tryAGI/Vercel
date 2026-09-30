
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The origin of this definition. 'api' means created via the API. Undefined means it originated from a deployment (vercel.json).
    /// </summary>
    public enum AutoSDKSharedea12f8422dc06e51CronsDefinitionSource
    {
        /// <summary>
        ///
        /// </summary>
        Api,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedea12f8422dc06e51CronsDefinitionSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedea12f8422dc06e51CronsDefinitionSource value)
        {
            return value switch
            {
                AutoSDKSharedea12f8422dc06e51CronsDefinitionSource.Api => "api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedea12f8422dc06e51CronsDefinitionSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => AutoSDKSharedea12f8422dc06e51CronsDefinitionSource.Api,
                _ => null,
            };
        }
    }
}