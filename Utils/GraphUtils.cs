using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SynonymService.Models;

namespace SynonymService.Utils
{
    public class GraphUtils
    {
        public static void GetSynonymsTuples(Node keyword, List<Path> data)
        {
            keyword.Visited = true;
            List<Node> outgoing = new List<Node>();

            foreach (Path path in data) //O(n)
            {
                if (path.Synonym.Value.ToLower() == keyword.Value.ToLower() && !path.Synonym.Visited)
                {
                    outgoing.Add(path.Keyword);
                    //Result.Add(path.Keyword.Value);
                }
                else if (path.Keyword.Value.ToLower() == keyword.Value.ToLower() && !path.Keyword.Visited)
                {
                    outgoing.Add(path.Synonym);
                    //Result.Add(path.Synonym.Value);
                }
            }

            foreach (Node node in outgoing) 
            {
                GetSynonymsTuples(node, data);
            }

        }
    }
}
