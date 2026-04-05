
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseState
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
    public static class UpdateFlagResponseStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseState value)
        {
            return value switch
            {
                UpdateFlagResponseState.Active => "active",
                UpdateFlagResponseState.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseState? ToEnum(string value)
        {
            return value switch
            {
                "active" => UpdateFlagResponseState.Active,
                "archived" => UpdateFlagResponseState.Archived,
                _ => null,
            };
        }
    }
}