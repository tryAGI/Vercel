
#nullable enable

namespace Vercel
{
    /// <summary>
    /// How we see the domain's configuration. - `CNAME`: Domain has a CNAME pointing to Vercel. - `A`: Domain's A record is resolving to Vercel. - `http`: Domain is resolving to Vercel but may be behind a Proxy. - `dns-01`: Domain is not resolving to Vercel but dns-01 challenge is enabled. - `null`: Domain is not resolving to Vercel.
    /// </summary>
    public enum GetDomainConfigResponseConfiguredBy
    {
        /// <summary>
        /// Domain has a CNAME pointing to Vercel. - `A`: Domain's A record is resolving to Vercel. - `http`: Domain is resolving to Vercel but may be behind a Proxy. - `dns-01`: Domain is not resolving to Vercel but dns-01 challenge is enabled. - `null`: Domain is not resolving to Vercel.
        /// </summary>
        A,
        /// <summary>
        /// Domain has a CNAME pointing to Vercel. - `A`: Domain's A record is resolving to Vercel. - `http`: Domain is resolving to Vercel but may be behind a Proxy. - `dns-01`: Domain is not resolving to Vercel but dns-01 challenge is enabled. - `null`: Domain is not resolving to Vercel.
        /// </summary>
        Cname,
        /// <summary>
        /// Domain has a CNAME pointing to Vercel. - `A`: Domain's A record is resolving to Vercel. - `http`: Domain is resolving to Vercel but may be behind a Proxy. - `dns-01`: Domain is not resolving to Vercel but dns-01 challenge is enabled. - `null`: Domain is not resolving to Vercel.
        /// </summary>
        Dns01,
        /// <summary>
        /// Domain has a CNAME pointing to Vercel. - `A`: Domain's A record is resolving to Vercel. - `http`: Domain is resolving to Vercel but may be behind a Proxy. - `dns-01`: Domain is not resolving to Vercel but dns-01 challenge is enabled. - `null`: Domain is not resolving to Vercel.
        /// </summary>
        Http,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDomainConfigResponseConfiguredByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDomainConfigResponseConfiguredBy value)
        {
            return value switch
            {
                GetDomainConfigResponseConfiguredBy.A => "A",
                GetDomainConfigResponseConfiguredBy.Cname => "CNAME",
                GetDomainConfigResponseConfiguredBy.Dns01 => "dns-01",
                GetDomainConfigResponseConfiguredBy.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDomainConfigResponseConfiguredBy? ToEnum(string value)
        {
            return value switch
            {
                "A" => GetDomainConfigResponseConfiguredBy.A,
                "CNAME" => GetDomainConfigResponseConfiguredBy.Cname,
                "dns-01" => GetDomainConfigResponseConfiguredBy.Dns01,
                "http" => GetDomainConfigResponseConfiguredBy.Http,
                _ => null,
            };
        }
    }
}