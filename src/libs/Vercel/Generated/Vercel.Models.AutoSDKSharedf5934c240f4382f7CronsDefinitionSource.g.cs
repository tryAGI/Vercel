
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The origin of this definition. 'api' means created via the API. Undefined means it originated from a deployment (vercel.json).
    /// </summary>
    public enum AutoSDKSharedf5934c240f4382f7CronsDefinitionSource
    {
        /// <summary>
        ///
        /// </summary>
        Api,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedf5934c240f4382f7CronsDefinitionSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf5934c240f4382f7CronsDefinitionSource value)
        {
            return value switch
            {
                AutoSDKSharedf5934c240f4382f7CronsDefinitionSource.Api => "api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf5934c240f4382f7CronsDefinitionSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => AutoSDKSharedf5934c240f4382f7CronsDefinitionSource.Api,
                _ => null,
            };
        }
    }
}