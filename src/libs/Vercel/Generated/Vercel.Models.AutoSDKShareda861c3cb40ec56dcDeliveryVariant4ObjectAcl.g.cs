
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ObjectAcl
    {
        /// <summary>
        ///
        /// </summary>
        AuthenticatedRead,
        /// <summary>
        ///
        /// </summary>
        AwsExecRead,
        /// <summary>
        ///
        /// </summary>
        BucketOwnerFullControl,
        /// <summary>
        ///
        /// </summary>
        BucketOwnerRead,
        /// <summary>
        ///
        /// </summary>
        Private,
        /// <summary>
        ///
        /// </summary>
        PublicRead,
        /// <summary>
        ///
        /// </summary>
        PublicReadWrite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ObjectAclExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ObjectAcl value)
        {
            return value switch
            {
                AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ObjectAcl.AuthenticatedRead => "authenticated-read",
                AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ObjectAcl.AwsExecRead => "aws-exec-read",
                AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ObjectAcl.BucketOwnerFullControl => "bucket-owner-full-control",
                AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ObjectAcl.BucketOwnerRead => "bucket-owner-read",
                AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ObjectAcl.Private => "private",
                AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ObjectAcl.PublicRead => "public-read",
                AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ObjectAcl.PublicReadWrite => "public-read-write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ObjectAcl? ToEnum(string value)
        {
            return value switch
            {
                "authenticated-read" => AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ObjectAcl.AuthenticatedRead,
                "aws-exec-read" => AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ObjectAcl.AwsExecRead,
                "bucket-owner-full-control" => AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ObjectAcl.BucketOwnerFullControl,
                "bucket-owner-read" => AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ObjectAcl.BucketOwnerRead,
                "private" => AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ObjectAcl.Private,
                "public-read" => AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ObjectAcl.PublicRead,
                "public-read-write" => AutoSDKShareda861c3cb40ec56dcDeliveryVariant4ObjectAcl.PublicReadWrite,
                _ => null,
            };
        }
    }
}