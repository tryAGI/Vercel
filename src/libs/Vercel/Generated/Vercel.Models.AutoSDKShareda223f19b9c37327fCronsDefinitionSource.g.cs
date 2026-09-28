
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The origin of this definition. 'api' means created via the API. Undefined means it originated from a deployment (vercel.json).
    /// </summary>
    public enum AutoSDKShareda223f19b9c37327fCronsDefinitionSource
    {
        /// <summary>
        ///
        /// </summary>
        Api,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda223f19b9c37327fCronsDefinitionSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda223f19b9c37327fCronsDefinitionSource value)
        {
            return value switch
            {
                AutoSDKShareda223f19b9c37327fCronsDefinitionSource.Api => "api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda223f19b9c37327fCronsDefinitionSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => AutoSDKShareda223f19b9c37327fCronsDefinitionSource.Api,
                _ => null,
            };
        }
    }
}