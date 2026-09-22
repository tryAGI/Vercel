
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared290e0be6a2cc986eReadySubstate
    {
        /// <summary>
        ///
        /// </summary>
        Promoted,
        /// <summary>
        ///
        /// </summary>
        Rolling,
        /// <summary>
        ///
        /// </summary>
        Staged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared290e0be6a2cc986eReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared290e0be6a2cc986eReadySubstate value)
        {
            return value switch
            {
                AutoSDKShared290e0be6a2cc986eReadySubstate.Promoted => "PROMOTED",
                AutoSDKShared290e0be6a2cc986eReadySubstate.Rolling => "ROLLING",
                AutoSDKShared290e0be6a2cc986eReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared290e0be6a2cc986eReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => AutoSDKShared290e0be6a2cc986eReadySubstate.Promoted,
                "ROLLING" => AutoSDKShared290e0be6a2cc986eReadySubstate.Rolling,
                "STAGED" => AutoSDKShared290e0be6a2cc986eReadySubstate.Staged,
                _ => null,
            };
        }
    }
}