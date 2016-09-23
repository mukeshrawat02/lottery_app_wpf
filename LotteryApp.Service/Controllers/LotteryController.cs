using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LotteryApp.Common.Utils;

namespace LotteryApp.Service.Controllers
{
    public class LotteryController : ApiController
    {
        public IEnumerable<int> GetLotteryNumbers(int count, int startNumber, int endNumber)
        {
            return LotteryHelper.GenerateLotteryNumbers(count, startNumber, endNumber);
        }
    }
}
