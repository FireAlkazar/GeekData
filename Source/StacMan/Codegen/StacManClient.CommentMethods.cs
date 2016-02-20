// <auto-generated>
//     This file was generated by a T4 template.
//     Don't change it directly as your change would get overwritten. Instead, make changes
//     to the .tt file (i.e. the T4 template) and save it to regenerate this file.
// </auto-generated>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace StackExchange.StacMan
{
    public partial class StacManClient : ICommentMethods
    {
        /// <summary>
        /// Stack Exchange API Comments methods
        /// </summary>
        public ICommentMethods Comments
        {
            get { return this; }
        }

        Task<StacManResponse<Comment>> ICommentMethods.GetAll(string site, string filter, int? page, int? pagesize, DateTime? fromdate, DateTime? todate, Comments.Sort? sort, DateTime? mindate, DateTime? maxdate, int? min, int? max, Order? order)
        {
            ValidateString(site, "site");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, mindate: mindate, maxdate: maxdate, min: min, max: max);

            var ub = new ApiUrlBuilder(Version, "/comments", useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", mindate);
            ub.AddParameter("max", maxdate);
            ub.AddParameter("min", min);
            ub.AddParameter("max", max);
            ub.AddParameter("order", order);

            return CreateApiTask<Comment>(ub, HttpMethod.GET, "/comments");
        }

        Task<StacManResponse<Comment>> ICommentMethods.GetByIds(string site, IEnumerable<int> ids, string filter, int? page, int? pagesize, DateTime? fromdate, DateTime? todate, Comments.Sort? sort, DateTime? mindate, DateTime? maxdate, int? min, int? max, Order? order)
        {
            ValidateString(site, "site");
            ValidateEnumerable(ids, "ids");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, mindate: mindate, maxdate: maxdate, min: min, max: max);

            var ub = new ApiUrlBuilder(Version, String.Format("/comments/{0}", String.Join(";", ids)), useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", mindate);
            ub.AddParameter("max", maxdate);
            ub.AddParameter("min", min);
            ub.AddParameter("max", max);
            ub.AddParameter("order", order);

            return CreateApiTask<Comment>(ub, HttpMethod.GET, "/comments/{ids}");
        }

        Task<StacManResponse<Comment>> ICommentMethods.Delete(string site, string access_token, int id, string filter, bool? preview)
        {
            ValidateString(site, "site");
            ValidateString(access_token, "access_token");
            ValidateMinApiVersion("2.1");

            var ub = new ApiUrlBuilder(Version, String.Format("/comments/{0}/delete", id), useHttps: true);

            ub.AddParameter("site", site);
            ub.AddParameter("access_token", access_token);
            ub.AddParameter("filter", filter);
            ub.AddParameter("preview", preview);

            return CreateApiTask<Comment>(ub, HttpMethod.POST, "/comments/{id}/delete");
        }

        Task<StacManResponse<Comment>> ICommentMethods.Edit(string site, string access_token, int id, string body, string filter, bool? preview)
        {
            ValidateString(site, "site");
            ValidateString(access_token, "access_token");
            ValidateString(body, "body");
            ValidateMinApiVersion("2.1");

            var ub = new ApiUrlBuilder(Version, String.Format("/comments/{0}/edit", id), useHttps: true);

            ub.AddParameter("site", site);
            ub.AddParameter("access_token", access_token);
            ub.AddParameter("body", body);
            ub.AddParameter("filter", filter);
            ub.AddParameter("preview", preview);

            return CreateApiTask<Comment>(ub, HttpMethod.POST, "/comments/{id}/edit");
        }
    }

    /// <summary>
    /// Stack Exchange API Comments methods
    /// </summary>
    public interface ICommentMethods
    {
        /// <summary>
        /// Get all comments on the site. (API Method: "/comments")
        /// </summary>
        Task<StacManResponse<Comment>> GetAll(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Comments.Sort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null);

        /// <summary>
        /// Get comments identified by a set of ids. (API Method: "/comments/{ids}")
        /// </summary>
        Task<StacManResponse<Comment>> GetByIds(string site, IEnumerable<int> ids, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Comments.Sort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null);

        /// <summary>
        /// Delete a comment identified by its id. [auth required] (API Method: "/comments/{id}/delete") -- introduced in API version 2.1
        /// </summary>
        Task<StacManResponse<Comment>> Delete(string site, string access_token, int id, string filter = null, bool? preview = null);

        /// <summary>
        /// Edit a comment identified by its id. [auth required] (API Method: "/comments/{id}/edit") -- introduced in API version 2.1
        /// </summary>
        Task<StacManResponse<Comment>> Edit(string site, string access_token, int id, string body, string filter = null, bool? preview = null);

    }
}