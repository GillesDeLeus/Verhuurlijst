using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tutorial.Models
{
    public class Repository
    {
        private static List<GeustResponse> responses = new List<GeustResponse>();

        public static IEnumerable<GeustResponse> Responses {
            get {
                return responses;
            }
                }
        public static void AddResponse(GeustResponse response) {
            responses.Add(response);

        }
    }
}
