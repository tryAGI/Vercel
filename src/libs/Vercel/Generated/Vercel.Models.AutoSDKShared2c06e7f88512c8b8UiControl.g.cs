
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2c06e7f88512c8b8UiControl
    {
        /// <summary>
        ///
        /// </summary>
        MultiVercelRegion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2c06e7f88512c8b8UiControlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2c06e7f88512c8b8UiControl value)
        {
            return value switch
            {
                AutoSDKShared2c06e7f88512c8b8UiControl.MultiVercelRegion => "multi-vercel-region",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2c06e7f88512c8b8UiControl? ToEnum(string value)
        {
            return value switch
            {
                "multi-vercel-region" => AutoSDKShared2c06e7f88512c8b8UiControl.MultiVercelRegion,
                _ => null,
            };
        }
    }
}