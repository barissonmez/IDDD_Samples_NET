using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SaaSOvation.Common.Port.Adapters.Persistence;
using SaaSOvation.Collaboration.Application.Forums.Data;

namespace SaaSOvation.Collaboration.Application.Forums
{
    public class PostQueryService : AbstractQueryService
    {
        public PostQueryService(DataSource dataSource)
            : base(dataSource)
        {
        }

        public IList<PostData> GetAllPostsDataByDiscussion(string tenantId, string discussionId)
        {
            return QueryObjects<PostData>(
                    "select * from tbl_vw_post where tenant_id = ? and discussion_id = ?",
                    new JoinOn(),
                    tenantId,
                    discussionId);
        }

        public PostData GetPostDataById(string tenantId, string postId)
        {
            return QueryObject<PostData>(
                    "select * from tbl_vw_post where tenant_id = ? and post_id = ?",
                    new JoinOn(),
                    tenantId,
                    postId);
        }
    }
}
