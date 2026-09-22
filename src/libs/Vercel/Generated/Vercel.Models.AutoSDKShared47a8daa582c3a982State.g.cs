
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared47a8daa582c3a982State
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
    public static class AutoSDKShared47a8daa582c3a982StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared47a8daa582c3a982State value)
        {
            return value switch
            {
                AutoSDKShared47a8daa582c3a982State.Active => "active",
                AutoSDKShared47a8daa582c3a982State.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared47a8daa582c3a982State? ToEnum(string value)
        {
            return value switch
            {
                "active" => AutoSDKShared47a8daa582c3a982State.Active,
                "archived" => AutoSDKShared47a8daa582c3a982State.Archived,
                _ => null,
            };
        }
    }
}