﻿using System;
using System.Linq.Expressions;

namespace Octokit.GraphQL.Core.UnitTests.Models
{
    class Simple : QueryableValue<Simple>
    {
        public Simple(Expression expression)
            : base(expression)
        {
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Number { get; set; }
        public int? NullableNumber { get; set; }

        internal static Simple Create(Expression expression)
        {
            return new Simple(expression);
        }
    }
}
