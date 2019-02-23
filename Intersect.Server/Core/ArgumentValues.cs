﻿using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Intersect.Server.Core
{
    public sealed class ArgumentValues : IEnumerable<object>
    {
        [NotNull]
        private readonly IList<object> mValues;

        public object Value => mValues.FirstOrDefault();

        [NotNull]
        public IList<object> Values => mValues.ToImmutableList() ?? throw new InvalidOperationException();

        public bool IsEmpty => mValues.Count < 1;

        public ArgumentValues([CanBeNull] params object[] values)
            : this(values.AsEnumerable())
        {
        }

        public ArgumentValues([CanBeNull] IEnumerable<object> values = null)
        {
            mValues = new List<object>(values ?? new object[0]);
        }

        public IEnumerator<object> GetEnumerator() => mValues.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public TValue ToTypedValue<TValue>()
        {
            if (mValues.FirstOrDefault() is TValue typedValue)
            {
                return typedValue;
            }

            return default(TValue);
        }

        public IList<TValue> ToTypedValues<TValue>()
        {
            return mValues.Select(value => value is TValue typedValue ? typedValue : default(TValue)).ToImmutableList();
        }
    }
}