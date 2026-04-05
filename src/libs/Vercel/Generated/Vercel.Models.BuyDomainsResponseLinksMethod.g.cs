
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuyDomainsResponseLinksMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Get,
        /// <summary>
        /// 
        /// </summary>
        Patch,
        /// <summary>
        /// 
        /// </summary>
        Post,
        /// <summary>
        /// 
        /// </summary>
        Put,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyDomainsResponseLinksMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyDomainsResponseLinksMethod value)
        {
            return value switch
            {
                BuyDomainsResponseLinksMethod.Delete => "DELETE",
                BuyDomainsResponseLinksMethod.Get => "GET",
                BuyDomainsResponseLinksMethod.Patch => "PATCH",
                BuyDomainsResponseLinksMethod.Post => "POST",
                BuyDomainsResponseLinksMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyDomainsResponseLinksMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => BuyDomainsResponseLinksMethod.Delete,
                "GET" => BuyDomainsResponseLinksMethod.Get,
                "PATCH" => BuyDomainsResponseLinksMethod.Patch,
                "POST" => BuyDomainsResponseLinksMethod.Post,
                "PUT" => BuyDomainsResponseLinksMethod.Put,
                _ => null,
            };
        }
    }
}