using System;
using System.Collections.Generic;

namespace Stacky
{
    public partial class StackyClient
    {
        public virtual IPagedList<Comment> GetComments(IEnumerable<int> fromUserIds, CommentSort sortBy = CommentSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? toUserId = null, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null)
        {
            string[] urlParameters = null;
            if (toUserId.HasValue)
            {
                urlParameters = new string[] { fromUserIds.Vectorize(), "comments", toUserId.ToString() };
            }
            else
            {
                urlParameters = new string[] { fromUserIds.Vectorize(), "comments" };
            }

            var response = MakeRequest<CommentResponse>("users", urlParameters, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null,
                sort = sortBy.ToString().ToLower(),
                order = GetSortDirection(sortDirection),
                min = min ?? null,
                max = max ?? null
            });
            return new PagedList<Comment>(response.Comments, response);
        }

        public virtual IPagedList<Comment> GetComments(int fromUserId, CommentSort sortBy = CommentSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? toUserId = null, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null)
        {
            return GetComments(fromUserId.ToArray(), sortBy, sortDirection, toUserId, page, pageSize, fromDate, toDate, min, max);
        }

        public virtual IPagedList<Comment> GetCommentsByPost(int postId, CommentSort sortBy = CommentSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null)
        {
            return GetCommentsByPost(postId.ToArray(), sortBy, sortDirection, page, pageSize, fromDate, toDate, min, max);
        }

        public virtual IPagedList<Comment> GetCommentsByPost(IEnumerable<int> postIds, CommentSort sortBy = CommentSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null)
        {
            var response = MakeRequest<CommentResponse>("posts", new string[] { postIds.Vectorize(), "comments" }, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null,
                sort = sortBy.ToString().ToLower(),
                order = GetSortDirection(sortDirection),
                min = min ?? null,
                max = max ?? null
            });
            return new PagedList<Comment>(response.Comments, response);
        }

        public virtual IPagedList<Comment> GetAnswerComments(int answerId, CommentSort sortBy = CommentSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null)
        {
            return GetAnswerComments(answerId.ToArray(), sortBy, sortDirection, page, pageSize, fromDate, toDate, min, max);
        }

        public virtual IPagedList<Comment> GetAnswerComments(IEnumerable<int> answerIds, CommentSort sortBy = CommentSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null)
        {
            var response = MakeRequest<CommentResponse>("answers", new string[] { answerIds.Vectorize(), "comments" }, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null,
                sort = sortBy.ToString().ToLower(),
                order = GetSortDirection(sortDirection),
                min = min ?? null,
                max = max ?? null
            });
            return new PagedList<Comment>(response.Comments, response);
        }

        /// <summary>
        /// Gets all the comments in the site
        /// </summary>
        /// <param name="sortBy">How the current sort should be ordered.</param>
        /// <param name="sortDirection"></param>
        /// <param name="page">The pagination offset for the current collection. Affected by the specified pagesize.</param>
        /// <param name="pageSize">The number of collection results to display during pagination. Should be between 0 and 100 inclusive.</param>
        /// <param name="fromDate"> Unix timestamp of the minimum creation date on a returned item.</param>
        /// <param name="toDate">Unix timestamp of the maximum creation date on a returned item.</param>
        /// <param name="min">Minimum of the range to include in the response according to the current sort.</param>
        /// <param name="max">Maximum of the range to include in the response according to the current sort.</param>
        /// <returns></returns>
        public virtual IPagedList<Comment> GetComments(CommentSort sortBy = CommentSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null)
        {
            var response = MakeRequest<CommentResponse>("answers", null, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null,
                sort = sortBy.ToString().ToLower(),
                order = GetSortDirection(sortDirection),
                min = min ?? null,
                max = max ?? null
            });
            return new PagedList<Comment>(response.Comments, response);
        }
    }
}