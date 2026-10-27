
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The origin of this definition. 'api' means created via the API. Undefined means it originated from a deployment (vercel.json).
    /// </summary>
    public enum AutoSDKShared429ed81b15078f20CronsDefinitionSource
    {
        /// <summary>
        ///
        /// </summary>
        Api,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared429ed81b15078f20CronsDefinitionSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared429ed81b15078f20CronsDefinitionSource value)
        {
            return value switch
            {
                AutoSDKShared429ed81b15078f20CronsDefinitionSource.Api => "api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared429ed81b15078f20CronsDefinitionSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => AutoSDKShared429ed81b15078f20CronsDefinitionSource.Api,
                _ => null,
            };
        }
    }
}