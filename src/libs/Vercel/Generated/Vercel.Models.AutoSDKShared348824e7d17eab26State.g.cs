
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared348824e7d17eab26State
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
    public static class AutoSDKShared348824e7d17eab26StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared348824e7d17eab26State value)
        {
            return value switch
            {
                AutoSDKShared348824e7d17eab26State.Active => "active",
                AutoSDKShared348824e7d17eab26State.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared348824e7d17eab26State? ToEnum(string value)
        {
            return value switch
            {
                "active" => AutoSDKShared348824e7d17eab26State.Active,
                "archived" => AutoSDKShared348824e7d17eab26State.Archived,
                _ => null,
            };
        }
    }
}