using Ilmume.Primary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ilmume.CoreAPI.SDK.API
{
    public interface IReviewsAPI
    {
        List<Reviews> GetTopFiveCustomerReviews();

        Reviews GetReviewsForCoach();

        Reviews GetReviewsForProgram();

        Reviews ReviewCoach();

        Reviews ReviewProgram();
    }
}
