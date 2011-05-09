using System.Collections.Generic;
using System;

namespace Stacky
{
    public partial class StackyClient
    {
        public virtual IPagedList<Tag> GetTags(TagSort sortBy = TagSort.Popular, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null)
        {
            return GetTags("tags", null, sortBy.ToString().ToLower(), GetSortDirection(sortDirection), page, pageSize);
        }

        private IPagedList<Tag> GetTags(string method, string[] urlParameters, string sort, string order, int? page = null, int? pageSize = null)
        {
            var response = MakeRequest<TagResponse>(method, urlParameters, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                sort = sort,
                order = order
            });
            return new PagedList<Tag>(response.Tags, response);
        }

        public virtual IPagedList<Tag> GetTagsByUser(int userId, int? page = null, int? pageSize = null)
        {
            return GetTagsByUser(userId.ToArray(), page, pageSize);
        }

        public virtual IPagedList<Tag> GetTagsByUser(IEnumerable<int> userIds, int? page = null, int? pageSize = null)
        {
            //TODO: does this method support sort and order?
            return GetTags("users", new string[] { userIds.Vectorize(), "tags" }, null, null, page, pageSize);
        }

        public virtual IPagedList<TagSynonym> GetAllTagSynonyms(TagSynonymSort sortBy = TagSynonymSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, int? min = null, int? max = null)
        {
            var response = MakeRequest<TagSynonymResponse>("tags", new string[] { "synonyms" }, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                sort = sortBy.ToString(),
                order = GetSortDirection(sortDirection),
                max = max,
                min = min
            });
            return new PagedList<TagSynonym>(response.TagSynonyms, response);
        }

        public virtual IPagedList<TagSynonym> GetTagSynonyms(string tag, TagSynonymSort sortBy = TagSynonymSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, int? min = null, int? max = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            return GetTagSynonyms(new string[] { tag }, sortBy, sortDirection, page, pageSize, min, max, fromDate, toDate);
        }

        public virtual IPagedList<TagSynonym> GetTagSynonyms(IEnumerable<string> tags, TagSynonymSort sortBy = TagSynonymSort.Creation, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, int? min = null, int? max = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            var response = MakeRequest<TagSynonymResponse>("tags", new string[] { tags.Vectorize(), "synonyms" }, new
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
            });
            return new PagedList<TagSynonym>(response.TagSynonyms, response);
        }

        public IEnumerable<TagWiki> GetTagWikis(string tag)
        {
            return GetTagWikis(new string[] { tag });
        }

        public IEnumerable<TagWiki> GetTagWikis(IEnumerable<string> tags)
        {
            var response = MakeRequest<TagWikiResponse>("tags", new string[] { tags.Vectorize(), "wikis" }, new
            {
                key = apiKey
            });
            return response.TagWikis;
        }

        /// <summary>
        /// Returns the top 30 question askers active in a single tag, of either all-time or the last 30 days.
        /// </summary>
        /// <param name="tag">The name of the tag to query</param>
        /// <param name="period">The period of time to query</param>
        /// <returns></returns>
        public IEnumerable<TopUser> GetTopAskers(string tag, TopUserPeriod period)
        {
            return GetTopAskers(new string[] { tag }, period);
        }

        /// <summary>
        /// Returns the top 30 question askers active in a single tag, of either all-time or the last 30 days.
        /// </summary>
        /// <param name="tags">The list of tags to query</param>
        /// <param name="period">The time period to query</param>
        /// <returns></returns>
        public IEnumerable<TopUser> GetTopAskers(IEnumerable<string> tags, TopUserPeriod period)
        {
            var sortArgs = period.GetAttribute<SortArgsAttribute>();
            var response = MakeRequest<TopUserResponse>("tags", new string[] { tags.Vectorize(), "top-askers", sortArgs.Sort }, new
            {
                key = apiKey
            });
            return response.TopUsers;
        }

        /// <summary>
        /// Returns the top 30 question answerers active in a single tag, of either all-time or the last 30 days.
        /// </summary>
        /// <param name="tag">The name of the tag to query</param>
        /// <param name="period">The period of time to query</param>
        /// <returns></returns>
        public IEnumerable<TopUser> GetTopAnswerers(string tag, TopUserPeriod period)
        {
            return GetTopAnswerers(new string[] { tag }, period);
        }

        /// <summary>
        /// Returns the top 30 question answerers active in a single tag, of either all-time or the last 30 days.
        /// </summary>
        /// <param name="tags">The list of tags to query</param>
        /// <param name="period">The time period to query</param>
        /// <returns></returns>
        public IEnumerable<TopUser> GetTopAnswerers(IEnumerable<string> tags, TopUserPeriod period)
        {
            var sortArgs = period.GetAttribute<SortArgsAttribute>();
            var response = MakeRequest<TopUserResponse>("tags", new string[] { tags.Vectorize(), "top-answerers", sortArgs.Sort }, new
            {
                key = apiKey
            });
            return response.TopUsers;
        }
    }
}