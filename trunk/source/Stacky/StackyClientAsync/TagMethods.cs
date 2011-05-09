using System;
using System.Collections.Generic;

namespace Stacky
{
#if SILVERLIGHT
    public partial class StackyClient
#else
    public partial class StackyClientAsync
#endif
    {
        public virtual void GetTags(Action<IPagedList<Tag>> onSuccess, Action<ApiException> onError, TagSort sortBy = TagSort.Popular, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null)
        {
            GetTags(onSuccess, onError, "tags", null, sortBy.ToString().ToLower(), GetSortDirection(sortDirection), page, pageSize);
        }

        private void GetTags(Action<IPagedList<Tag>> onSuccess, Action<ApiException> onError, string method, string[] urlParameters, string sort, string order, int? page = null, int? pageSize = null)
        {
            MakeRequest<TagResponse>(method, urlParameters, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                sort = sort,
                order = order
            }, (items) => onSuccess(new PagedList<Tag>(items.Tags, items)), onError);
        }

        public virtual void GetTagsByUser(int userId, Action<IPagedList<Tag>> onSuccess, Action<ApiException> onError, int? page = null, int? pageSize = null)
        {
            GetTagsByUser(userId.ToArray(), onSuccess, onError, page, pageSize);
        }

        public virtual void GetTagsByUser(IEnumerable<int> userIds, Action<IPagedList<Tag>> onSuccess, Action<ApiException> onError, int? page = null, int? pageSize = null)
        {
            //TODO: does this method support sort and order?
            GetTags(onSuccess, onError, "users", new string[] { userIds.Vectorize(), "tags" }, null, null, page, pageSize);
        }

        public virtual void GetAllTagSynonyms(Action<IPagedList<TagSynonym>> onSuccess, Action<ApiException> onError, TagSynonymSort sortBy = TagSynonymSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, int? min = null, int? max = null)
        {
            MakeRequest<TagSynonymResponse>("tags", new string[] { "synonyms" }, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                sort = sortBy.ToString(),
                order = GetSortDirection(sortDirection),
                max = max,
                min = min
            }, (items) => onSuccess(new PagedList<TagSynonym>(items.TagSynonyms, items)), onError);
        }

        public virtual void GetTagSynonyms(Action<IPagedList<TagSynonym>> onSuccess, Action<ApiException> onError, string tag, TagSynonymSort sortBy = TagSynonymSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, int? min = null, int? max = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            GetTagSynonyms(onSuccess, onError, new string[] { tag }, sortBy, sortDirection, page, pageSize, min, max, fromDate, toDate);
        }

        public virtual void GetTagSynonyms(Action<IPagedList<TagSynonym>> onSuccess, Action<ApiException> onError, IEnumerable<string> tags, TagSynonymSort sortBy = TagSynonymSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, int? min = null, int? max = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            MakeRequest<TagSynonymResponse>("tags", new string[] { tags.Vectorize(), "synonyms" }, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                sort = sortBy.ToString(),
                order = GetSortDirection(sortDirection),
                max = max,
                min = min,
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null
            }, (items) => onSuccess(new PagedList<TagSynonym>(items.TagSynonyms, items)), onError);
        }

        public void GetTagWikis(Action<IEnumerable<TagWiki>> onSuccess, Action<ApiException> onError, string tag)
        {
            GetTagWikis(onSuccess, onError, new string[] { tag });
        }

        public void GetTagWikis(Action<IEnumerable<TagWiki>> onSuccess, Action<ApiException> onError, IEnumerable<string> tags)
        {
            MakeRequest<TagWikiResponse>("tags", new string[] { tags.Vectorize(), "wikis" }, new
            {
                key = apiKey
            }, (items) => onSuccess(items.TagWikis), onError);
        }

        /// <summary>
        /// Returns the top 30 question askers active in a single tag, of either all-time or the last 30 days.
        /// </summary>
        /// <param name="onSuccess"></param>
        /// <param name="onError"></param>
        /// <param name="tag">The name of the tag to query</param>
        /// <param name="period">The period of time to query</param>
        /// <returns></returns>
        public void GetTopAskers(Action<IEnumerable<TopUser>> onSuccess, Action<ApiException> onError, string tag, TopUserPeriod period)
        {
            GetTopAskers(onSuccess, onError, new string[] { tag }, period);
        }

        /// <summary>
        /// Returns the top 30 question askers active in a single tag, of either all-time or the last 30 days.
        /// </summary>
        /// <param name="onSuccess"></param>
        /// <param name="onError"></param>
        /// <param name="tags">The list of tags to query</param>
        /// <param name="period">The time period to query</param>
        /// <returns></returns>
        public void GetTopAskers(Action<IEnumerable<TopUser>> onSuccess, Action<ApiException> onError, IEnumerable<string> tags, TopUserPeriod period)
        {
            var sortArgs = period.GetAttribute<SortArgsAttribute>();
            MakeRequest<TopUserResponse>("tags", new string[] { tags.Vectorize(), "top-askers", sortArgs.Sort }, new
            {
                key = apiKey
            }, (items) => onSuccess(items.TopUsers), onError);
        }

        /// <summary>
        /// Returns the top 30 question askers active in a single tag, of either all-time or the last 30 days.
        /// </summary>
        /// <param name="onSuccess"></param>
        /// <param name="onError"></param>
        /// <param name="tag">The name of the tag to query</param>
        /// <param name="period">The period of time to query</param>
        /// <returns></returns>
        public void GetTopAnswerers(Action<IEnumerable<TopUser>> onSuccess, Action<ApiException> onError, string tag, TopUserPeriod period)
        {
            GetTopAnswerers(onSuccess, onError, new string[] { tag }, period);
        }

        /// <summary>
        /// Returns the top 30 question askers active in a single tag, of either all-time or the last 30 days.
        /// </summary>
        /// <param name="onSuccess"></param>
        /// <param name="onError"></param>
        /// <param name="tags">The list of tags to query</param>
        /// <param name="period">The time period to query</param>
        /// <returns></returns>
        public void GetTopAnswerers(Action<IEnumerable<TopUser>> onSuccess, Action<ApiException> onError, IEnumerable<string> tags, TopUserPeriod period)
        {
            var sortArgs = period.GetAttribute<SortArgsAttribute>();
            MakeRequest<TopUserResponse>("tags", new string[] { tags.Vectorize(), "top-answerers", sortArgs.Sort }, new
            {
                key = apiKey
            }, (items) => onSuccess(items.TopUsers), onError);
        }
    }
}