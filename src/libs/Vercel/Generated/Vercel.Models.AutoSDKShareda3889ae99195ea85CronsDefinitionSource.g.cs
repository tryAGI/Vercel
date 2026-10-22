
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The origin of this definition. 'api' means created via the API. Undefined means it originated from a deployment (vercel.json).
    /// </summary>
    public enum AutoSDKShareda3889ae99195ea85CronsDefinitionSource
    {
        /// <summary>
        ///
        /// </summary>
        Api,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda3889ae99195ea85CronsDefinitionSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3889ae99195ea85CronsDefinitionSource value)
        {
            return value switch
            {
                AutoSDKShareda3889ae99195ea85CronsDefinitionSource.Api => "api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3889ae99195ea85CronsDefinitionSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => AutoSDKShareda3889ae99195ea85CronsDefinitionSource.Api,
                _ => null,
            };
        }
    }
}