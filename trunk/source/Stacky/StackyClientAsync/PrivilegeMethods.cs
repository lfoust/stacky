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
        /// <summary>
        /// Get a list of all the Privileges
        /// </summary>
        /// <param name="onSuccess"></param>
        /// <param name="onError"></param>
        public void GetPrivileges(Action<IEnumerable<Privilege>> onSuccess, Action<ApiException> onError)
        {
            MakeRequest<PrivilegeResponse>("privileges", null, new
            {
                key = apiKey
            }, (items) => onSuccess(items.Privileges), onError);
        }
    }
}