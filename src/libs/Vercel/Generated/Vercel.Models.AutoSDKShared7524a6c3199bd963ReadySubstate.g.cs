
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7524a6c3199bd963ReadySubstate
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
    public static class AutoSDKShared7524a6c3199bd963ReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7524a6c3199bd963ReadySubstate value)
        {
            return value switch
            {
                AutoSDKShared7524a6c3199bd963ReadySubstate.Promoted => "PROMOTED",
                AutoSDKShared7524a6c3199bd963ReadySubstate.Rolling => "ROLLING",
                AutoSDKShared7524a6c3199bd963ReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7524a6c3199bd963ReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => AutoSDKShared7524a6c3199bd963ReadySubstate.Promoted,
                "ROLLING" => AutoSDKShared7524a6c3199bd963ReadySubstate.Rolling,
                "STAGED" => AutoSDKShared7524a6c3199bd963ReadySubstate.Staged,
                _ => null,
            };
        }
    }
}