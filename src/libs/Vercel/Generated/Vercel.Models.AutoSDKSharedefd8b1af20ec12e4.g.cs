#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKSharedefd8b1af20ec12e4 : global::System.IEquatable<AutoSDKSharedefd8b1af20ec12e4>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared0695a89a4e02b217? Shared0695a89a4e02b217 { get; init; }
#else
        public global::Vercel.AutoSDKShared0695a89a4e02b217? Shared0695a89a4e02b217 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared0695a89a4e02b217))]
#endif
        public bool IsShared0695a89a4e02b217 => Shared0695a89a4e02b217 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared0695a89a4e02b217(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared0695a89a4e02b217? value)
        {
            value = Shared0695a89a4e02b217;
            return IsShared0695a89a4e02b217;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared0695a89a4e02b217 PickShared0695a89a4e02b217() => Shared0695a89a4e02b217 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared0695a89a4e02b217' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared6df91f8a45eab833? Shared6df91f8a45eab833 { get; init; }
#else
        public global::Vercel.AutoSDKShared6df91f8a45eab833? Shared6df91f8a45eab833 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared6df91f8a45eab833))]
#endif
        public bool IsShared6df91f8a45eab833 => Shared6df91f8a45eab833 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared6df91f8a45eab833(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared6df91f8a45eab833? value)
        {
            value = Shared6df91f8a45eab833;
            return IsShared6df91f8a45eab833;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared6df91f8a45eab833 PickShared6df91f8a45eab833() => Shared6df91f8a45eab833 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared6df91f8a45eab833' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedefd8b1af20ec12e4(global::Vercel.AutoSDKShared0695a89a4e02b217 value) => new AutoSDKSharedefd8b1af20ec12e4((global::Vercel.AutoSDKShared0695a89a4e02b217?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared0695a89a4e02b217?(AutoSDKSharedefd8b1af20ec12e4 @this) => @this.Shared0695a89a4e02b217;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedefd8b1af20ec12e4(global::Vercel.AutoSDKShared0695a89a4e02b217? value)
        {
            Shared0695a89a4e02b217 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedefd8b1af20ec12e4 FromShared0695a89a4e02b217(global::Vercel.AutoSDKShared0695a89a4e02b217? value) => new AutoSDKSharedefd8b1af20ec12e4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedefd8b1af20ec12e4(global::Vercel.AutoSDKShared6df91f8a45eab833 value) => new AutoSDKSharedefd8b1af20ec12e4((global::Vercel.AutoSDKShared6df91f8a45eab833?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared6df91f8a45eab833?(AutoSDKSharedefd8b1af20ec12e4 @this) => @this.Shared6df91f8a45eab833;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedefd8b1af20ec12e4(global::Vercel.AutoSDKShared6df91f8a45eab833? value)
        {
            Shared6df91f8a45eab833 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedefd8b1af20ec12e4 FromShared6df91f8a45eab833(global::Vercel.AutoSDKShared6df91f8a45eab833? value) => new AutoSDKSharedefd8b1af20ec12e4(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedefd8b1af20ec12e4(
            global::Vercel.AutoSDKShared0695a89a4e02b217? shared0695a89a4e02b217,
            global::Vercel.AutoSDKShared6df91f8a45eab833? shared6df91f8a45eab833
            )
        {
            Shared0695a89a4e02b217 = shared0695a89a4e02b217;
            Shared6df91f8a45eab833 = shared6df91f8a45eab833;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared6df91f8a45eab833 as object ??
            Shared0695a89a4e02b217 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared0695a89a4e02b217?.ToString() ??
            Shared6df91f8a45eab833?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared0695a89a4e02b217 && !IsShared6df91f8a45eab833 || !IsShared0695a89a4e02b217 && IsShared6df91f8a45eab833;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared0695a89a4e02b217, TResult>? shared0695a89a4e02b217 = null,
            global::System.Func<global::Vercel.AutoSDKShared6df91f8a45eab833, TResult>? shared6df91f8a45eab833 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared0695a89a4e02b217 is { } __value0 && shared0695a89a4e02b217 != null)
            {
                return shared0695a89a4e02b217(__value0);
            }
            else if (Shared6df91f8a45eab833 is { } __value1 && shared6df91f8a45eab833 != null)
            {
                return shared6df91f8a45eab833(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared0695a89a4e02b217>? shared0695a89a4e02b217 = null,

            global::System.Action<global::Vercel.AutoSDKShared6df91f8a45eab833>? shared6df91f8a45eab833 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared0695a89a4e02b217 is { } __value0)
            {
                shared0695a89a4e02b217?.Invoke(__value0);
            }
            else if (Shared6df91f8a45eab833 is { } __value1)
            {
                shared6df91f8a45eab833?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared0695a89a4e02b217>? shared0695a89a4e02b217 = null,
            global::System.Action<global::Vercel.AutoSDKShared6df91f8a45eab833>? shared6df91f8a45eab833 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared0695a89a4e02b217 is { } __value0)
            {
                shared0695a89a4e02b217?.Invoke(__value0);
            }
            else if (Shared6df91f8a45eab833 is { } __value1)
            {
                shared6df91f8a45eab833?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared0695a89a4e02b217,
                typeof(global::Vercel.AutoSDKShared0695a89a4e02b217),
                Shared6df91f8a45eab833,
                typeof(global::Vercel.AutoSDKShared6df91f8a45eab833),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AutoSDKSharedefd8b1af20ec12e4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared0695a89a4e02b217?>.Default.Equals(Shared0695a89a4e02b217, other.Shared0695a89a4e02b217) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared6df91f8a45eab833?>.Default.Equals(Shared6df91f8a45eab833, other.Shared6df91f8a45eab833)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKSharedefd8b1af20ec12e4 obj1, AutoSDKSharedefd8b1af20ec12e4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKSharedefd8b1af20ec12e4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKSharedefd8b1af20ec12e4 obj1, AutoSDKSharedefd8b1af20ec12e4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKSharedefd8b1af20ec12e4 o && Equals(o);
        }
    }
}
