
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfc279ab2bedb9f61UiControl
    {
        /// <summary>
        ///
        /// </summary>
        VercelCountry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfc279ab2bedb9f61UiControlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfc279ab2bedb9f61UiControl value)
        {
            return value switch
            {
                AutoSDKSharedfc279ab2bedb9f61UiControl.VercelCountry => "vercel-country",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfc279ab2bedb9f61UiControl? ToEnum(string value)
        {
            return value switch
            {
                "vercel-country" => AutoSDKSharedfc279ab2bedb9f61UiControl.VercelCountry,
                _ => null,
            };
        }
    }
}