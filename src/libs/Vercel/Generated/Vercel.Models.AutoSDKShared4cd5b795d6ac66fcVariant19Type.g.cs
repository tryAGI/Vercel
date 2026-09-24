
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared4cd5b795d6ac66fcVariant19Type
    {
        /// <summary>
        ///
        /// </summary>
        CursorOrigin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared4cd5b795d6ac66fcVariant19TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared4cd5b795d6ac66fcVariant19Type value)
        {
            return value switch
            {
                AutoSDKShared4cd5b795d6ac66fcVariant19Type.CursorOrigin => "cursor-origin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared4cd5b795d6ac66fcVariant19Type? ToEnum(string value)
        {
            return value switch
            {
                "cursor-origin" => AutoSDKShared4cd5b795d6ac66fcVariant19Type.CursorOrigin,
                _ => null,
            };
        }
    }
}