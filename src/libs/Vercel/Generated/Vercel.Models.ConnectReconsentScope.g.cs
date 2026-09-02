
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The affected authorization scope. user means each affected user must authorize again.
    /// </summary>
    public enum ConnectReconsentScope
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectReconsentScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectReconsentScope value)
        {
            return value switch
            {
                ConnectReconsentScope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectReconsentScope? ToEnum(string value)
        {
            return value switch
            {
                "user" => ConnectReconsentScope.User,
                _ => null,
            };
        }
    }
}