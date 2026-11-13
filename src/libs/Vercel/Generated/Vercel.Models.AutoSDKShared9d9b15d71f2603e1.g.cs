#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared9d9b15d71f2603e1 : global::System.IEquatable<AutoSDKShared9d9b15d71f2603e1>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedab96da75e8212e8f>? Shared0b826f992bd75d02 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedab96da75e8212e8f>? Shared0b826f992bd75d02 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared0b826f992bd75d02))]
#endif
        public bool IsShared0b826f992bd75d02 => Shared0b826f992bd75d02 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared0b826f992bd75d02(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedab96da75e8212e8f>? value)
        {
            value = Shared0b826f992bd75d02;
            return IsShared0b826f992bd75d02;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedab96da75e8212e8f> PickShared0b826f992bd75d02() => Shared0b826f992bd75d02 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared0b826f992bd75d02' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0001bb8e789a120e>? Sharedd868534aefc42f1c { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0001bb8e789a120e>? Sharedd868534aefc42f1c { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedd868534aefc42f1c))]
#endif
        public bool IsSharedd868534aefc42f1c => Sharedd868534aefc42f1c != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedd868534aefc42f1c(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0001bb8e789a120e>? value)
        {
            value = Sharedd868534aefc42f1c;
            return IsSharedd868534aefc42f1c;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0001bb8e789a120e> PickSharedd868534aefc42f1c() => Sharedd868534aefc42f1c is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedd868534aefc42f1c' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared9d9b15d71f2603e1(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedab96da75e8212e8f>? shared0b826f992bd75d02,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0001bb8e789a120e>? sharedd868534aefc42f1c
            )
        {
            Shared0b826f992bd75d02 = shared0b826f992bd75d02;
            Sharedd868534aefc42f1c = sharedd868534aefc42f1c;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Sharedd868534aefc42f1c as object ??
            Shared0b826f992bd75d02 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared0b826f992bd75d02?.ToString() ??
            Sharedd868534aefc42f1c?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared0b826f992bd75d02 && !IsSharedd868534aefc42f1c || !IsShared0b826f992bd75d02 && IsSharedd868534aefc42f1c;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedab96da75e8212e8f>, TResult>? shared0b826f992bd75d02 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0001bb8e789a120e>, TResult>? sharedd868534aefc42f1c = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared0b826f992bd75d02 is { } __value0 && shared0b826f992bd75d02 != null)
            {
                return shared0b826f992bd75d02(__value0);
            }
            else if (Sharedd868534aefc42f1c is { } __value1 && sharedd868534aefc42f1c != null)
            {
                return sharedd868534aefc42f1c(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedab96da75e8212e8f>>? shared0b826f992bd75d02 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0001bb8e789a120e>>? sharedd868534aefc42f1c = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared0b826f992bd75d02 is { } __value0)
            {
                shared0b826f992bd75d02?.Invoke(__value0);
            }
            else if (Sharedd868534aefc42f1c is { } __value1)
            {
                sharedd868534aefc42f1c?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedab96da75e8212e8f>>? shared0b826f992bd75d02 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0001bb8e789a120e>>? sharedd868534aefc42f1c = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared0b826f992bd75d02 is { } __value0)
            {
                shared0b826f992bd75d02?.Invoke(__value0);
            }
            else if (Sharedd868534aefc42f1c is { } __value1)
            {
                sharedd868534aefc42f1c?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared0b826f992bd75d02,
                typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedab96da75e8212e8f>),
                Sharedd868534aefc42f1c,
                typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0001bb8e789a120e>),
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
        public bool Equals(AutoSDKShared9d9b15d71f2603e1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedab96da75e8212e8f>?>.Default.Equals(Shared0b826f992bd75d02, other.Shared0b826f992bd75d02) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0001bb8e789a120e>?>.Default.Equals(Sharedd868534aefc42f1c, other.Sharedd868534aefc42f1c)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared9d9b15d71f2603e1 obj1, AutoSDKShared9d9b15d71f2603e1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared9d9b15d71f2603e1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared9d9b15d71f2603e1 obj1, AutoSDKShared9d9b15d71f2603e1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared9d9b15d71f2603e1 o && Equals(o);
        }
    }
}
