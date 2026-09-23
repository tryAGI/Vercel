
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8422af433e1bf486ReadySubstate
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
    public static class AutoSDKShared8422af433e1bf486ReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8422af433e1bf486ReadySubstate value)
        {
            return value switch
            {
                AutoSDKShared8422af433e1bf486ReadySubstate.Promoted => "PROMOTED",
                AutoSDKShared8422af433e1bf486ReadySubstate.Rolling => "ROLLING",
                AutoSDKShared8422af433e1bf486ReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8422af433e1bf486ReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => AutoSDKShared8422af433e1bf486ReadySubstate.Promoted,
                "ROLLING" => AutoSDKShared8422af433e1bf486ReadySubstate.Rolling,
                "STAGED" => AutoSDKShared8422af433e1bf486ReadySubstate.Staged,
                _ => null,
            };
        }
    }
}