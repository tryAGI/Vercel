
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbca3e7a986162538ChecksState
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Registered,
        /// <summary>
        ///
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedbca3e7a986162538ChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbca3e7a986162538ChecksState value)
        {
            return value switch
            {
                AutoSDKSharedbca3e7a986162538ChecksState.Completed => "completed",
                AutoSDKSharedbca3e7a986162538ChecksState.Registered => "registered",
                AutoSDKSharedbca3e7a986162538ChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbca3e7a986162538ChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AutoSDKSharedbca3e7a986162538ChecksState.Completed,
                "registered" => AutoSDKSharedbca3e7a986162538ChecksState.Registered,
                "running" => AutoSDKSharedbca3e7a986162538ChecksState.Running,
                _ => null,
            };
        }
    }
}