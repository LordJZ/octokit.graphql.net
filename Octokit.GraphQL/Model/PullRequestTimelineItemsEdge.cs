namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// An edge in a connection.
    /// </summary>
    public class PullRequestTimelineItemsEdge : QueryableValue<PullRequestTimelineItemsEdge>
    {
        internal PullRequestTimelineItemsEdge(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public string Cursor { get; }

        /// <summary>
        /// The item at the end of the edge.
        /// </summary>
        public PullRequestTimelineItems Node => this.CreateProperty(x => x.Node, Octokit.GraphQL.Model.PullRequestTimelineItems.Create);

        internal static PullRequestTimelineItemsEdge Create(Expression expression)
        {
            return new PullRequestTimelineItemsEdge(expression);
        }
    }
}