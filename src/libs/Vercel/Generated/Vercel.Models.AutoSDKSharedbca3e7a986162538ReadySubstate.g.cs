
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbca3e7a986162538ReadySubstate
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
    public static class AutoSDKSharedbca3e7a986162538ReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbca3e7a986162538ReadySubstate value)
        {
            return value switch
            {
                AutoSDKSharedbca3e7a986162538ReadySubstate.Promoted => "PROMOTED",
                AutoSDKSharedbca3e7a986162538ReadySubstate.Rolling => "ROLLING",
                AutoSDKSharedbca3e7a986162538ReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbca3e7a986162538ReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => AutoSDKSharedbca3e7a986162538ReadySubstate.Promoted,
                "ROLLING" => AutoSDKSharedbca3e7a986162538ReadySubstate.Rolling,
                "STAGED" => AutoSDKSharedbca3e7a986162538ReadySubstate.Staged,
                _ => null,
            };
        }
    }
}