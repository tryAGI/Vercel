
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6b9922eb6c026513Handle
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
    public static class AutoSDKShared6b9922eb6c026513HandleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6b9922eb6c026513Handle value)
        {
            return value switch
            {
                AutoSDKShared6b9922eb6c026513Handle.Finalize => "finalize",
                AutoSDKShared6b9922eb6c026513Handle.Init => "init",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6b9922eb6c026513Handle? ToEnum(string value)
        {
            return value switch
            {
                "finalize" => AutoSDKShared6b9922eb6c026513Handle.Finalize,
                "init" => AutoSDKShared6b9922eb6c026513Handle.Init,
                _ => null,
            };
        }
    }
}