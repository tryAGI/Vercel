
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which challenge types the domain can use for issuing certs.
    /// </summary>
    public enum GetDomainConfigResponseAcceptedChallenge
    {
        /// <summary>
        /// 
        /// </summary>
        Dns01,
        /// <summary>
        /// 
        /// </summary>
        Http01,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDomainConfigResponseAcceptedChallengeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDomainConfigResponseAcceptedChallenge value)
        {
            return value switch
            {
                GetDomainConfigResponseAcceptedChallenge.Dns01 => "dns-01",
                GetDomainConfigResponseAcceptedChallenge.Http01 => "http-01",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDomainConfigResponseAcceptedChallenge? ToEnum(string value)
        {
            return value switch
            {
                "dns-01" => GetDomainConfigResponseAcceptedChallenge.Dns01,
                "http-01" => GetDomainConfigResponseAcceptedChallenge.Http01,
                _ => null,
            };
        }
    }
}