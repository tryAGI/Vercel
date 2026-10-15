
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd474136b05e5e447Handle
    {
        /// <summary>
        ///
        /// </summary>
        Finalize,
        /// <summary>
        ///
        /// </summary>
        Init,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedd474136b05e5e447HandleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd474136b05e5e447Handle value)
        {
            return value switch
            {
                AutoSDKSharedd474136b05e5e447Handle.Finalize => "finalize",
                AutoSDKSharedd474136b05e5e447Handle.Init => "init",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd474136b05e5e447Handle? ToEnum(string value)
        {
            return value switch
            {
                "finalize" => AutoSDKSharedd474136b05e5e447Handle.Finalize,
                "init" => AutoSDKSharedd474136b05e5e447Handle.Init,
                _ => null,
            };
        }
    }
}