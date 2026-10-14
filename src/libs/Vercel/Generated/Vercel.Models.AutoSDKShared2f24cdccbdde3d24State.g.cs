
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2f24cdccbdde3d24State
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Archived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2f24cdccbdde3d24StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2f24cdccbdde3d24State value)
        {
            return value switch
            {
                AutoSDKShared2f24cdccbdde3d24State.Active => "active",
                AutoSDKShared2f24cdccbdde3d24State.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2f24cdccbdde3d24State? ToEnum(string value)
        {
            return value switch
            {
                "active" => AutoSDKShared2f24cdccbdde3d24State.Active,
                "archived" => AutoSDKShared2f24cdccbdde3d24State.Archived,
                _ => null,
            };
        }
    }
}