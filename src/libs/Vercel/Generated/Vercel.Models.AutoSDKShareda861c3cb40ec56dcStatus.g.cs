
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda861c3cb40ec56dcStatus
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
        /// <summary>
        ///
        /// </summary>
        Errored,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda861c3cb40ec56dcStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda861c3cb40ec56dcStatus value)
        {
            return value switch
            {
                AutoSDKShareda861c3cb40ec56dcStatus.Disabled => "disabled",
                AutoSDKShareda861c3cb40ec56dcStatus.Enabled => "enabled",
                AutoSDKShareda861c3cb40ec56dcStatus.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda861c3cb40ec56dcStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => AutoSDKShareda861c3cb40ec56dcStatus.Disabled,
                "enabled" => AutoSDKShareda861c3cb40ec56dcStatus.Enabled,
                "errored" => AutoSDKShareda861c3cb40ec56dcStatus.Errored,
                _ => null,
            };
        }
    }
}