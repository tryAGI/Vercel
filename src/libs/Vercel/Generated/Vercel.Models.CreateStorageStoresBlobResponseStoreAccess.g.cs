
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateStorageStoresBlobResponseStoreAccess
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStorageStoresBlobResponseStoreAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStorageStoresBlobResponseStoreAccess value)
        {
            return value switch
            {
                CreateStorageStoresBlobResponseStoreAccess.Private => "private",
                CreateStorageStoresBlobResponseStoreAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStorageStoresBlobResponseStoreAccess? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateStorageStoresBlobResponseStoreAccess.Private,
                "public" => CreateStorageStoresBlobResponseStoreAccess.Public,
                _ => null,
            };
        }
    }
}