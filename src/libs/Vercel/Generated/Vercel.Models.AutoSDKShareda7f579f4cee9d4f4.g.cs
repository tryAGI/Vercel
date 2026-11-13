#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShareda7f579f4cee9d4f4 : global::System.IEquatable<AutoSDKShareda7f579f4cee9d4f4>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKSharedab96da75e8212e8f? Sharedab96da75e8212e8f { get; init; }
#else
        public global::Vercel.AutoSDKSharedab96da75e8212e8f? Sharedab96da75e8212e8f { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedab96da75e8212e8f))]
#endif
        public bool IsSharedab96da75e8212e8f => Sharedab96da75e8212e8f != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedab96da75e8212e8f(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharedab96da75e8212e8f? value)
        {
            value = Sharedab96da75e8212e8f;
            return IsSharedab96da75e8212e8f;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharedab96da75e8212e8f PickSharedab96da75e8212e8f() => Sharedab96da75e8212e8f is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedab96da75e8212e8f' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared0001bb8e789a120e? Shared0001bb8e789a120e { get; init; }
#else
        public global::Vercel.AutoSDKShared0001bb8e789a120e? Shared0001bb8e789a120e { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared0001bb8e789a120e))]
#endif
        public bool IsShared0001bb8e789a120e => Shared0001bb8e789a120e != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared0001bb8e789a120e(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared0001bb8e789a120e? value)
        {
            value = Shared0001bb8e789a120e;
            return IsShared0001bb8e789a120e;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared0001bb8e789a120e PickShared0001bb8e789a120e() => Shared0001bb8e789a120e is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared0001bb8e789a120e' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShareda7f579f4cee9d4f4(global::Vercel.AutoSDKSharedab96da75e8212e8f value) => new AutoSDKShareda7f579f4cee9d4f4((global::Vercel.AutoSDKSharedab96da75e8212e8f?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharedab96da75e8212e8f?(AutoSDKShareda7f579f4cee9d4f4 @this) => @this.Sharedab96da75e8212e8f;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShareda7f579f4cee9d4f4(global::Vercel.AutoSDKSharedab96da75e8212e8f? value)
        {
            Sharedab96da75e8212e8f = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShareda7f579f4cee9d4f4 FromSharedab96da75e8212e8f(global::Vercel.AutoSDKSharedab96da75e8212e8f? value) => new AutoSDKShareda7f579f4cee9d4f4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShareda7f579f4cee9d4f4(global::Vercel.AutoSDKShared0001bb8e789a120e value) => new AutoSDKShareda7f579f4cee9d4f4((global::Vercel.AutoSDKShared0001bb8e789a120e?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared0001bb8e789a120e?(AutoSDKShareda7f579f4cee9d4f4 @this) => @this.Shared0001bb8e789a120e;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShareda7f579f4cee9d4f4(global::Vercel.AutoSDKShared0001bb8e789a120e? value)
        {
            Shared0001bb8e789a120e = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShareda7f579f4cee9d4f4 FromShared0001bb8e789a120e(global::Vercel.AutoSDKShared0001bb8e789a120e? value) => new AutoSDKShareda7f579f4cee9d4f4(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShareda7f579f4cee9d4f4(
            global::Vercel.AutoSDKSharedab96da75e8212e8f? sharedab96da75e8212e8f,
            global::Vercel.AutoSDKShared0001bb8e789a120e? shared0001bb8e789a120e
            )
        {
            Sharedab96da75e8212e8f = sharedab96da75e8212e8f;
            Shared0001bb8e789a120e = shared0001bb8e789a120e;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared0001bb8e789a120e as object ??
            Sharedab96da75e8212e8f as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Sharedab96da75e8212e8f?.ToString() ??
            Shared0001bb8e789a120e?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSharedab96da75e8212e8f && !IsShared0001bb8e789a120e || !IsSharedab96da75e8212e8f && IsShared0001bb8e789a120e;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKSharedab96da75e8212e8f, TResult>? sharedab96da75e8212e8f = null,
            global::System.Func<global::Vercel.AutoSDKShared0001bb8e789a120e, TResult>? shared0001bb8e789a120e = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedab96da75e8212e8f is { } __value0 && sharedab96da75e8212e8f != null)
            {
                return sharedab96da75e8212e8f(__value0);
            }
            else if (Shared0001bb8e789a120e is { } __value1 && shared0001bb8e789a120e != null)
            {
                return shared0001bb8e789a120e(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKSharedab96da75e8212e8f>? sharedab96da75e8212e8f = null,

            global::System.Action<global::Vercel.AutoSDKShared0001bb8e789a120e>? shared0001bb8e789a120e = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedab96da75e8212e8f is { } __value0)
            {
                sharedab96da75e8212e8f?.Invoke(__value0);
            }
            else if (Shared0001bb8e789a120e is { } __value1)
            {
                shared0001bb8e789a120e?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKSharedab96da75e8212e8f>? sharedab96da75e8212e8f = null,
            global::System.Action<global::Vercel.AutoSDKShared0001bb8e789a120e>? shared0001bb8e789a120e = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Sharedab96da75e8212e8f is { } __value0)
            {
                sharedab96da75e8212e8f?.Invoke(__value0);
            }
            else if (Shared0001bb8e789a120e is { } __value1)
            {
                shared0001bb8e789a120e?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Sharedab96da75e8212e8f,
                typeof(global::Vercel.AutoSDKSharedab96da75e8212e8f),
                Shared0001bb8e789a120e,
                typeof(global::Vercel.AutoSDKShared0001bb8e789a120e),
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
        public bool Equals(AutoSDKShareda7f579f4cee9d4f4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharedab96da75e8212e8f?>.Default.Equals(Sharedab96da75e8212e8f, other.Sharedab96da75e8212e8f) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared0001bb8e789a120e?>.Default.Equals(Shared0001bb8e789a120e, other.Shared0001bb8e789a120e)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShareda7f579f4cee9d4f4 obj1, AutoSDKShareda7f579f4cee9d4f4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShareda7f579f4cee9d4f4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShareda7f579f4cee9d4f4 obj1, AutoSDKShareda7f579f4cee9d4f4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShareda7f579f4cee9d4f4 o && Equals(o);
        }
    }
}
