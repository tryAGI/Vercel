
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0603220ab3785539UiControl
    {
        /// <summary>
        ///
        /// </summary>
        VercelRegion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0603220ab3785539UiControlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0603220ab3785539UiControl value)
        {
            return value switch
            {
                AutoSDKShared0603220ab3785539UiControl.VercelRegion => "vercel-region",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0603220ab3785539UiControl? ToEnum(string value)
        {
            return value switch
            {
                "vercel-region" => AutoSDKShared0603220ab3785539UiControl.VercelRegion,
                _ => null,
            };
        }
    }
}