
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagRequestState
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
    public static class UpdateFlagRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagRequestState value)
        {
            return value switch
            {
                UpdateFlagRequestState.Active => "active",
                UpdateFlagRequestState.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagRequestState? ToEnum(string value)
        {
            return value switch
            {
                "active" => UpdateFlagRequestState.Active,
                "archived" => UpdateFlagRequestState.Archived,
                _ => null,
            };
        }
    }
}