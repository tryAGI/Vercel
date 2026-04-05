
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuySingleDomainResponseLinksMethod
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
    public static class BuySingleDomainResponseLinksMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuySingleDomainResponseLinksMethod value)
        {
            return value switch
            {
                BuySingleDomainResponseLinksMethod.Delete => "DELETE",
                BuySingleDomainResponseLinksMethod.Get => "GET",
                BuySingleDomainResponseLinksMethod.Patch => "PATCH",
                BuySingleDomainResponseLinksMethod.Post => "POST",
                BuySingleDomainResponseLinksMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuySingleDomainResponseLinksMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => BuySingleDomainResponseLinksMethod.Delete,
                "GET" => BuySingleDomainResponseLinksMethod.Get,
                "PATCH" => BuySingleDomainResponseLinksMethod.Patch,
                "POST" => BuySingleDomainResponseLinksMethod.Post,
                "PUT" => BuySingleDomainResponseLinksMethod.Put,
                _ => null,
            };
        }
    }
}