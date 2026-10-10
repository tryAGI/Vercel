
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The product the caller is logging out of. Only applies when reason is logout and tokenId is current.
    /// </summary>
    public enum DeleteAuthTokenLogoutSource
    {
        /// <summary>
        ///
        /// </summary>
        V0,
        /// <summary>
        ///
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteAuthTokenLogoutSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAuthTokenLogoutSource value)
        {
            return value switch
            {
                DeleteAuthTokenLogoutSource.V0 => "v0",
                DeleteAuthTokenLogoutSource.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAuthTokenLogoutSource? ToEnum(string value)
        {
            return value switch
            {
                "v0" => DeleteAuthTokenLogoutSource.V0,
                "vercel" => DeleteAuthTokenLogoutSource.Vercel,
                _ => null,
            };
        }
    }
}