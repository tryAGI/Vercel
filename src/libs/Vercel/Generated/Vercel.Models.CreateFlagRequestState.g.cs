
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagRequestState
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
    public static class CreateFlagRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagRequestState value)
        {
            return value switch
            {
                CreateFlagRequestState.Active => "active",
                CreateFlagRequestState.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagRequestState? ToEnum(string value)
        {
            return value switch
            {
                "active" => CreateFlagRequestState.Active,
                "archived" => CreateFlagRequestState.Archived,
                _ => null,
            };
        }
    }
}