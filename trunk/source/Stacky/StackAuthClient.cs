using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stacky
{
    public class StackAuthClient
    {
        public StackAuthClient(string version, IUrlClient client, IProtocol protocol)
        {
            BaseUrl = "http://stackauth.com";
            WebClient = client;
            Protocol = protocol;
            Version = version;
        }

        public IUrlClient WebClient { get; set; }
        public IProtocol Protocol { get; set; }
        public string BaseUrl { get; private set; }
        public string Version { get; private set; }

        #region Methods

        public T MakeRequest<T>(string method, string[] urlArguments, object queryStringArguments)
             where T : new()
        {
            var httpResponse = GetResponse(method, urlArguments, UrlHelper.ObjectToDictionary(queryStringArguments));
            return ParseResponse<T>(httpResponse);
        }

        public T ParseResponse<T>(HttpResponse httpResponse)
            where T : new()
        {
            if (httpResponse.Error != null && String.IsNullOrEmpty(httpResponse.Body))
                throw new ApiException("Error retrieving url", null, httpResponse.Error, httpResponse.Url);

            var response = Protocol.GetResponse<T>(httpResponse.Body);
            if (response.Error != null)
                throw new ApiException(response.Error);

            return response.Data;
        }

        public HttpResponse GetResponse(string method, string[] urlArguments, Dictionary<string, string> queryStringArguments)
        {
            Uri url = UrlHelper.BuildUrl(method, Version, BaseUrl, urlArguments, queryStringArguments);
            return WebClient.MakeRequest(url);
        }

        #endregion

        public virtual IEnumerable<SiteInfo> GetSites(int? page = null, int? pageSize = null, bool? minimal = null)
        {
            return MakeRequest<SitesResponse>("sites", null, new
            {
                page = page,
                pagesize = pageSize,
                minimal = minimal
            }).Sites;
        }

        public virtual IEnumerable<AssociatedUser> GetAssociatedUsers(Guid associationId, int? page = 0, int? pageSize = null)
        {
            return MakeRequest<AssociatedUsersResponse>("users", new string[] { associationId.ToString(), "associated" }, new
            {
                page = page,
                pagesize = pageSize
            }).Users;
        }
    }
}