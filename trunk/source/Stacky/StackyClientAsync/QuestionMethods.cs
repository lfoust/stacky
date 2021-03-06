﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacky
{
#if SILVERLIGHT
    public partial class StackyClient
#else
    public partial class StackyClientAsync
#endif
    {
        public virtual void GetQuestions(Action<IPagedList<Question>> onSuccess, Action<ApiException> onError, QuestionSort sortBy = QuestionSort.Activity, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, bool includeBody = false, bool includeComments = false, bool includeAnswers = false, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null, string[] tags = null)
        {
            var sortArgs = sortBy.GetAttribute<SortArgsAttribute>();
            GetQuestions(onSuccess, onError, "questions", sortArgs.UrlArgs, sortArgs.Sort, GetSortDirection(sortDirection), page, pageSize, includeBody, includeAnswers, includeComments, fromDate, toDate, min, max, tags);
        }

        public virtual void GetQuestionsByUser(int userId, Action<IPagedList<Question>> onSuccess, Action<ApiException> onError, QuestionsByUserSort sortBy = QuestionsByUserSort.Activity, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, bool includeBody = false, bool includeComments = false, bool includeAnswers = false, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null, string[] tags = null)
        {
            GetQuestions(onSuccess, onError, "users", new string[] { userId.ToString(), "questions" }, sortBy.ToString().ToLower(), GetSortDirection(sortDirection), page, pageSize, includeBody, includeComments, includeAnswers, fromDate, toDate, min, max, tags);
        }

        public virtual void GetFavoriteQuestions(int userId, Action<IPagedList<Question>> onSuccess, Action<ApiException> onError, FavoriteQuestionsSort sortBy = FavoriteQuestionsSort.Activity, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, bool includeBody = false, bool includeAnswers = false, bool includeComments = false, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null, string[] tags = null)
        {
            GetQuestions(onSuccess, onError, "users", new string[] { userId.ToString(), "favorites" }, sortBy.ToString().ToLower(), GetSortDirection(sortDirection), page, pageSize, includeBody, includeComments, includeAnswers, fromDate, toDate, min, max, tags);
        }

        private void GetQuestions(Action<IPagedList<Question>> onSuccess, Action<ApiException> onError, string method, string[] urlArgs, string sort, string order, int? page, int? pageSize, bool includeBody, bool includeComments, bool includeAnswers, DateTime? fromDate, DateTime? toDate, int? min, int? max, params string[] tags)
        {
            MakeRequest<QuestionResponse>(method, urlArgs, new
            {
                key = apiKey,
                page = page ?? null,
                pagesize = pageSize ?? null,
                body = includeBody ? (bool?)true : null,
                comments = includeComments ? (bool?)true : null,
                answers = includeAnswers ? (bool?)true : null,
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null,
                tagged = tags == null ? (string)null : String.Join(" ", tags),
                sort = sort,
                order = order,
                min = min,
                max = max
            }, (items) => onSuccess(new PagedList<Question>(items.Questions, items)), onError);
        }

        public virtual void GetQuestions(IEnumerable<int> questionIds, Action<IPagedList<Question>> onSuccess, Action<ApiException> onError, int? page = null, int? pageSize = null, bool includeBody = false, bool includeComments = false, bool includeAnswers = false)
        {
            MakeRequest<QuestionResponse>("questions", new string[] { questionIds.Vectorize() }, new
            {
                key = apiKey,
                body = includeBody ? (bool?)true : null,
                comments = includeComments ? (bool?)true : null,
                answers = includeAnswers ? (bool?)true : null,
                page = page ?? null,
                pagesize = pageSize ?? null
            }, (items) => onSuccess(new PagedList<Question>(items.Questions, items)), onError);
        }

        public virtual void GetQuestion(int questionId, Action<Question> onSuccess, Action<ApiException> onError, int? page = null, int? pageSize = null, bool includeBody = false, bool includeComments = false, bool includeAnswers = false)
        {
            GetQuestions(questionId.ToArray(), returnedQuestions => onSuccess(returnedQuestions.FirstOrDefault()), onError, page, pageSize, includeBody, includeComments, includeAnswers);
        }

        public virtual void GetQuestionTimeline(IEnumerable<int> questionIds, Action<IPagedList<PostEvent>> onSuccess, Action<ApiException> onError, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            MakeRequest<QuestionTimelineResponse>("questions", new string[] { questionIds.Vectorize(), "timeline" }, new
            {
                key = apiKey,
                fromdate = fromDate.HasValue ? (long?)fromDate.Value.ToUnixTime() : null,
                todate = toDate.HasValue ? (long?)toDate.Value.ToUnixTime() : null,
                page = page ?? null,
                pagesize = pageSize ?? null
            }, (items) => onSuccess(new PagedList<PostEvent>(items.Events, items)), onError);
        }

        public virtual void GetQuestionTimeline(int questionId, Action<IPagedList<PostEvent>> onSuccess, Action<ApiException> onError, int? page = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            GetQuestionTimeline(questionId.ToArray(), onSuccess, onError, page, pageSize, fromDate, toDate);
        }

        public virtual void Search(Action<IPagedList<Question>> onSuccess, Action<ApiException> onError, string inTitle = null, IEnumerable<string> tagged = null, IEnumerable<string> notTagged = null, SearchSort sortBy = SearchSort.Activity, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null)
        {
            string taggedString = null;
            if (tagged != null)
                taggedString = String.Join(" ", tagged.ToArray());

            string notTaggedString = null;
            if (notTagged != null)
                notTaggedString = String.Join(" ", notTagged.ToArray());

            MakeRequest<QuestionResponse>("search", null, new
            {
                key = apiKey,
                intitle = inTitle,
                tagged = taggedString,
                nottagged = notTaggedString,
                sort = sortBy,
                order = GetSortDirection(sortDirection),
                page = page ?? null,
                pagesize = pageSize ?? null
            }, (items) => onSuccess(new PagedList<Question>(items.Questions, items)), onError);
        }

        public virtual void GetLinkedQuestions(Action<IPagedList<Question>> onSuccess, Action<ApiException> onError, int questionId, QuestionSort sortBy = QuestionSort.Activity, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, bool includeBody = false, bool includeComments = false, bool includeAnswers = false, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null)
        {
            GetLinkedQuestions(onSuccess, onError, questionId.ToArray(), sortBy, sortDirection, page, pageSize, includeBody, includeComments, includeAnswers, fromDate, toDate, min, max);
        }

        public virtual void GetLinkedQuestions(Action<IPagedList<Question>> onSuccess, Action<ApiException> onError, IEnumerable<int> questionIds, QuestionSort sortBy = QuestionSort.Activity, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, bool includeBody = false, bool includeComments = false, bool includeAnswers = false, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null)
        { 
            GetQuestions(onSuccess, onError, "questions", new string[] { questionIds.Vectorize(), "linked" }, sortBy.ToString(), GetSortDirection(sortDirection), page, pageSize, includeBody, includeComments, includeAnswers, fromDate, toDate, min, max, null);
        }

        public virtual void GetRelatedQuestions(Action<IPagedList<Question>> onSuccess, Action<ApiException> onError, int questionId, QuestionSort sortBy = QuestionSort.Activity, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, bool includeBody = false, bool includeComments = false, bool includeAnswers = false, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null)
        {
            GetRelatedQuestions(onSuccess, onError, questionId.ToArray(), sortBy, sortDirection, page, pageSize, includeBody, includeComments, includeAnswers, fromDate, toDate, min, max);
        }

        public virtual void GetRelatedQuestions(Action<IPagedList<Question>> onSuccess, Action<ApiException> onError, IEnumerable<int> questionIds, QuestionSort sortBy = QuestionSort.Activity, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, bool includeBody = false, bool includeComments = false, bool includeAnswers = false, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null)
        {
            GetQuestions(onSuccess, onError, "questions", new string[] { questionIds.Vectorize(), "related" }, sortBy.ToString(), GetSortDirection(sortDirection), page, pageSize, includeBody, includeComments, includeAnswers, fromDate, toDate, min, max, null);
        }

        public virtual void GetNoAnswerQuestions(Action<IPagedList<Question>> onSuccess, Action<ApiException> onError, QuestionSort sortBy = QuestionSort.Activity, SortDirection sortDirection = SortDirection.Descending, int? page = null, int? pageSize = null, bool includeBody = false, bool includeComments = false, bool includeAnswers = false, DateTime? fromDate = null, DateTime? toDate = null, int? min = null, int? max = null)
        {
            GetQuestions(onSuccess, onError, "questions", new string[] { "no-answers" }, sortBy.ToString(), GetSortDirection(sortDirection), page, pageSize, includeBody, includeComments, includeAnswers, fromDate, toDate, min, max, null);
        }

        public virtual void GetSimilarQuestions(Action<IEnumerable<Question>> onSuccess, Action<ApiException> onError, string title, bool includeBody = false, bool includeComments = false, bool includeAnswers = false, IEnumerable<string> tagged = null, IEnumerable<string> notTagged = null)
        {
            string taggedString = null;
            if (tagged != null)
                taggedString = String.Join(";", tagged.ToArray());

            string notTaggedString = null;
            if (notTagged != null)
                notTaggedString = String.Join(";", notTagged.ToArray());

            MakeRequest<QuestionResponse>("similar", null, new
            {
                key = apiKey,
                title = title,
                body = includeBody ? (bool?)true : null,
                comments = includeComments ? (bool?)true : null,
                answers = includeAnswers ? (bool?)true : null,
                tagged = taggedString,
                nottagged = notTaggedString
            }, (items) => onSuccess(items.Questions), onError);
        }
    }
}