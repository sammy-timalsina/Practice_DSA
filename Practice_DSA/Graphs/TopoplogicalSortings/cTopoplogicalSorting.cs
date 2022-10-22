using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Graphs.TopoplogicalSortings
{
    public partial class cTopoplogicalSorting
    {
        public void  testCaseForTopologicalSorting()
        {
            int[][] arrbig = BigArray();
            //4
            //[[2,0],[1,0],[3,1],[3,2],[1,3]]
            //4
            //  [[2,0],[1,0],[3,1],[3,2],[1,3]]
            List<List<int>> list1 = new List<List<int>>
            {
                new List<int>{1,2},
                new List<int>{2},
                new List<int> {3,0},
                new List<int>{3}
            };
            int[][] arr = new int[][]
            {
                new int[]{1,0},
                new int[]{0,3},
                new int[]{0,2},
                new int[]{3,2},
                new int[]{2,5},
                new int[]{4,5},
                new int[]{5,6},
                new int[]{2,4}
            };
            int[][] arr1 = new int[][]
{
                new int[]{2,0},
                new int[]{1,0},
                new int[]{3,1},
                new int[]{3,2},
                new int[]{1,3}
};
            var ass = FindOrder(500,arrbig);
            //Topological sorting is only possible in DAG Directed acyclic graphs
            List<List<int>> list = new List<List<int>>();
            list.Add(new List<int> { });
            list.Add(new List<int> { });
            list.Add(new List<int> { 3 });
            list.Add(new List<int> { 1 });
            list.Add(new List<int> { 0, 1 });
            list.Add(new List<int> { 2, 0 });
            bool[]visited = new bool[list.Count];
            Stack<int> ds = new Stack<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (visited[i]) continue;
                bfs(list,i, visited, ds);
            }
            //topological sorting linear ordering 5,4,3,2,1,0
            
        }

        private int[][] BigArray()
        {
            int[][] ans =
                 new int[][]
 {new int[]{481,475},new int[]{196,63},new int[]{438,33},new int[]{212,328},new int[]{268,20},new int[]{226,288},new int[]{436,487},new int[]{199,494},new int[]{421,279},new int[]{369,14},new int[]{92,91},new int[]{183,174},new int[]{271,15},new int[]{4,435},new int[]{435,47},new int[]{217,460},new int[]{216,319},new int[]{468,125},new int[]{115,1},new int[]{435,383},new int[]{192,136},new int[]{86,103},new int[]{336,342},new int[]{5,301},new int[]{255,253},new int[]{185,37},new int[]{323,168},new int[]{417,241},new int[]{151,208},new int[]{347,53},new int[]{180,329},new int[]{198,452},new int[]{31,419},new int[]{406,74},new int[]{324,105},new int[]{164,494},new int[]{281,316},
new int[]{139,318},new int[]{269,214},new int[]{21,269},new int[]{271,234},new int[]{142,50},new int[]{304,375},new int[]{285,438},new int[]{120,251},new int[]{275,423},new int[]{447,91},new int[]{420,443},new int[]{163,476},new int[]{436,423},new int[]{76,487},new int[]{3,443},new int[]{262,309},new int[]{398,194},new int[]{26,468},new int[]{413,241},new int[]{187,472},new int[]{279,58},new int[]{29,48},new int[]{173,250},new int[]{423,499},new int[]{456,242},new int[]{34,102},
new int[]{42,376},new int[]{286,159},new int[]{147,55},new int[]{208,449},new int[]{352,86},new int[]{147,228},new int[]{111,306},new int[]{108,238},new int[]{297,290},new int[]{199,472},new int[]{263,451},new int[]{383,116},new int[]{441,465},new int[]{490,396},new int[]{39,342},new int[]{16,441},new int[]{175,405},new int[]{139,70},new int[]{377,370},new int[]{244,276},new int[]{379,188},new int[]{175,188},new int[]{3,165},new int[]{291,485},new int[]{162,293},new int[]{336,140},new int[]{236,61},new int[]{297,424},new int[]{413,403},new int[]{75,161},new int[]{148,232},new int[]{9,313},new int[]{260,186},new int[]{390,116},new int[]{282,350},new int[]{239,357},
new int[]{33,285},new int[]{231,24},new int[]{342,82},new int[]{58,210},new int[]{423,356},new int[]{85,97},new int[]{197,346},new int[]{157,467},new int[]{210,364},new int[]{276,283},new int[]{170,54},new int[]{113,332},new int[]{48,270},new int[]{43,166},new int[]{416,42},new int[]{261,341},new int[]{373,76},new int[]{32,128},new int[]{382,302},new int[]{89,376},new int[]{414,363},new int[]{346,474},new int[]{245,460},new int[]{62,440},new int[]{138,458},new int[]{427,419},new int[]{412,128},new int[]{400,308},new int[]{229,286},new int[]{134,153},new int[]{332,488},new int[]{67,343},new int[]{401,202},new int[]{130,370},new int[]{345,242},new int[]{211,169},
new int[]{128,346},new int[]{372,128},new int[]{405,139},new int[]{181,344},new int[]{65,52},new int[]{257,40},new int[]{355,133},new int[]{188,416},new int[]{128,362},new int[]{30,365},new int[]{329,88},new int[]{261,32},new int[]{197,171},new int[]{387,463},new int[]{316,360},new int[]{364,250},new int[]{167,129},new int[]{25,318},new int[]{429,87},new int[]{274,272},new int[]{426,92},new int[]{24,127},new int[]{123,245},new int[]{238,164},new int[]{124,275},new int[]{98,48},new int[]{275,414},new int[]{217,409},new int[]{80,326},new int[]{486,180},new int[]{223,182},new int[]{344,236},new int[]{147,153},new int[]{20,63},new int[]{177,51},new int[]{430,57},
new int[]{447,108},new int[]{339,265},new int[]{455,6},new int[]{249,300},new int[]{367,279},new int[]{368,309},new int[]{460,175},new int[]{453,366},new int[]{352,129},new int[]{433,127},new int[]{319,78},new int[]{369,114},new int[]{156,400},new int[]{80,146},new int[]{190,194},new int[]{148,9},new int[]{230,107},new int[]{236,449},new int[]{417,287},new int[]{486,63},new int[]{92,301},new int[]{77,332},new int[]{101,111},new int[]{33,373},new int[]{189,265},new int[]{458,209},new int[]{318,219},new int[]{179,451},new int[]{30,259},new int[]{7,252},new int[]{45,403},new int[]{18,261},new int[]{7,413},new int[]{387,211},new int[]{230,80},new int[]{194,26},
new int[]{61,200},new int[]{336,483},new int[]{385,410},new int[]{196,260},new int[]{487,16},new int[]{193,494},new int[]{490,410},new int[]{217,499},new int[]{387,119},new int[]{30,174},new int[]{47,165},new int[]{409,352},new int[]{420,189},new int[]{294,242},new int[]{332,335},new int[]{341,13},new int[]{6,121},new int[]{479,282},new int[]{491,373},new int[]{60,269},new int[]{476,29},new int[]{239,59},new int[]{365,408},new int[]{361,205},new int[]{427,329},new int[]{185,30},new int[]{339,424},new int[]{6,190},new int[]{50,274},new int[]{483,98},new int[]{304,233},new int[]{214,294},new int[]{230,29},new int[]{441,401},new int[]{46,217},new int[]{339,446},
new int[]{54,183},new int[]{427,378},new int[]{9,319},new int[]{446,337},new int[]{120,219},new int[]{280,371},new int[]{390,495},new int[]{44,378},new int[]{108,95},new int[]{209,126},new int[]{234,156},new int[]{206,367},new int[]{178,273},new int[]{237,49},new int[]{374,155},new int[]{201,176},new int[]{208,122},new int[]{178,131},new int[]{12,432},new int[]{152,461},new int[]{309,386},new int[]{79,114},new int[]{337,271},new int[]{226,200},new int[]{177,117},new int[]{259,41},new int[]{427,423},new int[]{75,449},new int[]{430,427},new int[]{256,320},new int[]{497,309},new int[]{87,324},new int[]{383,311},new int[]{233,464},new int[]{97,161},new int[]{484,38},
new int[]{397,200},new int[]{312,258},new int[]{252,207},new int[]{478,169},new int[]{207,441},new int[]{210,28},new int[]{179,305},new int[]{250,85},new int[]{181,491},new int[]{250,426},new int[]{441,43},new int[]{484,115},new int[]{274,316},new int[]{432,55},new int[]{424,21},new int[]{361,252},new int[]{432,95},new int[]{423,174},new int[]{95,316},new int[]{65,15},new int[]{87,305},new int[]{255,109},new int[]{151,282},new int[]{391,85},new int[]{63,114},new int[]{411,279},new int[]{42,238},new int[]{160,461},new int[]{77,115},new int[]{211,287},new int[]{433,427},new int[]{230,179},new int[]{146,183},new int[]{255,128},new int[]{125,165},new int[]{126,383},
new int[]{483,490},new int[]{22,481},new int[]{90,232},new int[]{435,389},new int[]{387,246},new int[]{53,329},new int[]{131,7},new int[]{3,483},new int[]{281,191},new int[]{335,401},new int[]{464,482},new int[]{277,289},new int[]{418,489},new int[]{289,210},new int[]{83,199},new int[]{54,131},new int[]{439,206},new int[]{462,182},new int[]{107,147},new int[]{36,236},new int[]{72,267},new int[]{59,471},new int[]{86,91},new int[]{35,150},new int[]{331,420},new int[]{414,151},new int[]{467,266},new int[]{440,141},new int[]{410,349},new int[]{347,179},new int[]{475,241},new int[]{477,108},new int[]{138,237},new int[]{172,68},new int[]{69,97},new int[]{266,40},new int[]{43,466},
new int[]{118,406},new int[]{238,303},new int[]{92,216},new int[]{157,13},new int[]{127,337},new int[]{159,162},new int[]{343,344},new int[]{153,311},new int[]{114,255},new int[]{22,203},new int[]{236,46},new int[]{360,235},new int[]{57,358},new int[]{311,73},new int[]{450,444},new int[]{134,283},new int[]{444,60},new int[]{55,248},new int[]{372,343},new int[]{193,286},new int[]{20,458},new int[]{78,390},new int[]{360,477},new int[]{355,164},new int[]{465,212},new int[]{191,15},new int[]{374,241},new int[]{75,118},new int[]{115,374},new int[]{359,361},new int[]{153,479},new int[]{83,53},new int[]{377,406},new int[]{21,304},new int[]{348,176},new int[]{408,52},new int[]{366,25},
new int[]{375,80},new int[]{104,98},new int[]{84,428},new int[]{251,423},new int[]{437,29},new int[]{197,258},new int[]{213,488},new int[]{386,114},new int[]{204,375},new int[]{148,367},new int[]{129,363},new int[]{419,369},new int[]{176,113},new int[]{359,175},new int[]{160,303},new int[]{341,224},new int[]{352,41},new int[]{414,6},new int[]{135,214},new int[]{369,240},new int[]{48,361},new int[]{88,427},new int[]{311,305},new int[]{441,147},new int[]{333,148},new int[]{494,73},new int[]{6,82},new int[]{49,280},new int[]{423,471},new int[]{262,362},new int[]{222,316},new int[]{199,414},new int[]{370,84},new int[]{122,403},new int[]{9,315},new int[]{323,266},new int[]{270,338},
new int[]{460,72},new int[]{171,335},new int[]{28,342},new int[]{198,402},new int[]{367,9},new int[]{22,307},new int[]{13,34},new int[]{363,446},new int[]{297,404},new int[]{73,60},new int[]{95,53},new int[]{252,166},new int[]{216,414},new int[]{384,270},new int[]{464,50},new int[]{0,185},new int[]{478,19},new int[]{172,457},new int[]{2,479},new int[]{290,409},new int[]{138,369},new int[]{262,175},new int[]{93,368},new int[]{326,59},new int[]{13,125},new int[]{360,260},new int[]{333,110},new int[]{21,95},new int[]{323,134},new int[]{65,432},new int[]{33,411},new int[]{490,252},new int[]{389,169},new int[]{2,45},new int[]{18,248},new int[]{374,452},new int[]{457,56},new int[]{212,33},
new int[]{428,485},new int[]{229,323},new int[]{36,235},new int[]{324,276},new int[]{41,382},new int[]{451,400},new int[]{390,473},new int[]{487,33},new int[]{64,414},new int[]{271,461},new int[]{149,384},new int[]{360,31},new int[]{393,119},new int[]{294,235},new int[]{447,204},new int[]{450,499},new int[]{308,345},new int[]{44,295},new int[]{111,491},new int[]{125,49},new int[]{293,473},new int[]{182,3},new int[]{324,358},new int[]{302,455},new int[]{274,188},new int[]{297,387},new int[]{12,278},new int[]{348,86},new int[]{425,5},new int[]{163,463},new int[]{219,354},new int[]{481,380},new int[]{1,31},new int[]{43,80},new int[]{339,159},new int[]{452,303},new int[]{367,182},
new int[]{162,456},new int[]{420,99},new int[]{164,354},new int[]{214,84},new int[]{445,272},new int[]{16,14},new int[]{90,236},new int[]{483,180},new int[]{187,474},new int[]{312,53},new int[]{478,22},new int[]{185,376},new int[]{342,132},new int[]{219,35},new int[]{460,92},new int[]{151,350},new int[]{146,459},new int[]{469,287},new int[]{332,361},new int[]{179,145},new int[]{90,438},new int[]{11,417},new int[]{361,329},new int[]{173,423},new int[]{376,341},new int[]{456,327},new int[]{74,261},new int[]{261,402},new int[]{446,418},new int[]{62,339},new int[]{333,462},new int[]{92,32},new int[]{419,451},new int[]{269,452},new int[]{86,247},new int[]{441,6},new int[]{178,219},
new int[]{175,122},new int[]{474,176},new int[]{336,10},new int[]{400,483},new int[]{185,334},new int[]{343,175},new int[]{207,261},new int[]{77,157},new int[]{236,325},new int[]{416,234},new int[]{304,359},new int[]{136,165},new int[]{411,129},new int[]{272,230},new int[]{482,416},new int[]{51,245},new int[]{105,80},new int[]{243,50},new int[]{76,390},new int[]{420,261},new int[]{261,433},new int[]{218,448},new int[]{308,469},new int[]{272,52},new int[]{37,384},new int[]{7,70},new int[]{292,195},new int[]{312,57},new int[]{311,142},new int[]{97,431},new int[]{386,294},new int[]{316,320},new int[]{465,42},new int[]{440,433},new int[]{91,134},new int[]{179,302},new int[]{365,115},
new int[]{247,67},new int[]{139,149},new int[]{230,232},new int[]{384,1},new int[]{330,450},new int[]{41,144},new int[]{191,192},new int[]{54,271},new int[]{6,456},new int[]{481,443},new int[]{66,219},new int[]{346,301},new int[]{168,226},new int[]{269,353},new int[]{312,318},new int[]{104,467},new int[]{198,399},new int[]{377,398},new int[]{226,197},new int[]{440,164},new int[]{146,177},new int[]{292,494},new int[]{494,360},new int[]{64,464},new int[]{314,349},new int[]{254,25},new int[]{100,293},new int[]{20,274},new int[]{486,444},new int[]{17,173},new int[]{143,404},new int[]{338,203},new int[]{179,126},new int[]{135,84},new int[]{389,398},new int[]{404,480},new int[]{173,228},
new int[]{245,466},new int[]{98,194},new int[]{37,116},new int[]{328,111},new int[]{150,218},new int[]{31,237},new int[]{488,225},new int[]{151,397},new int[]{40,269},new int[]{242,136},new int[]{420,469},new int[]{378,61},new int[]{34,157},new int[]{268,485},new int[]{175,442},new int[]{460,437},new int[]{119,237},new int[]{410,174},new int[]{348,446},new int[]{334,282},new int[]{363,73},new int[]{205,185},new int[]{66,218},new int[]{97,159},new int[]{407,363},new int[]{288,269},new int[]{348,105},new int[]{315,272},new int[]{280,492},new int[]{175,483},new int[]{194,316},new int[]{33,81},new int[]{47,402},new int[]{480,248},new int[]{444,74},new int[]{127,373},new int[]{142,309},
new int[]{114,336},new int[]{384,213},new int[]{14,102},new int[]{228,83},new int[]{425,113},new int[]{427,42},new int[]{228,286},new int[]{333,205},new int[]{238,371},new int[]{3,334},new int[]{415,298},new int[]{396,482},new int[]{16,311},new int[]{77,269},new int[]{295,269},new int[]{432,322},new int[]{200,353},new int[]{360,388},new int[]{17,266},new int[]{370,350},new int[]{316,120},new int[]{146,186},new int[]{378,363},new int[]{186,224},new int[]{45,196},new int[]{401,434},new int[]{92,296},new int[]{82,120},new int[]{90,216},new int[]{263,352},new int[]{479,66},new int[]{13,185},new int[]{313,275},new int[]{437,469},new int[]{391,59},new int[]{214,74},new int[]{72,372},new int[]{383,27},
new int[]{258,235},new int[]{486,460},new int[]{137,78},new int[]{285,89},new int[]{293,238},new int[]{117,411},new int[]{91,51},new int[]{137,318},new int[]{409,345},new int[]{10,224},new int[]{407,274},new int[]{161,440},new int[]{351,100}
 };
            return ans;
        }

        //public void dfs(List<List<int>> adj,int vertex, bool[]visited, Stack<int> ds)
        //{
        //        if (visited[vertex]) return;
        //        visited[vertex] = true;
        //        foreach (int element in adj[vertex])
        //        {
        //           dfs(adj, element, visited, ds);
        //        }
        //        ds.Push(vertex);

        //}
        public void bfs(List<List<int>>adj,int vertex,bool[]visited,Stack<int>ds)
        {
            Queue<int> queue = new Queue<int>();    
            queue.Enqueue(vertex);
            while(queue.Count > 0)
            {
                int remove = queue.Dequeue();
                visited[vertex] = true;
                foreach (int element in adj[remove])
                {
                    if(visited[element]) continue;
                    queue.Enqueue(element);
                }
            }
            ds.Push(vertex);
        }
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            //first step creat adjacency list
            int len = numCourses;

            List<List<int>> adj = new List<List<int>>();
            for (int i = 0; i < len; i++)
                adj.Add(new List<int>());
            for (int i = 0; i < prerequisites.Length; i++)
            {
                int currentCourse = prerequisites[i][1];
                adj[currentCourse].Add(prerequisites[i][0]);
            }

            Stack<int> ds = new Stack<int>();
            bool[] visited = new bool[len];
            bool inValid = false;
            List<int> dds1 = new List<int>();
            for(int i=0;i<adj.Count;i++)
            {
                if (IsCycle(adj, i, visited, dds1))
                {
                    inValid = true;
                    break;
                }
            }
   
            if (inValid) return new int[] { };
            for (int i = 0; i < len; i++)
            {

                if (visited[i]) continue;
                List<int> dds = new List<int>();
                dfs(adj, i, visited, ds);
                if (inValid) break;
            }
            if (inValid) return new int[] { };
            if (ds.Count != len) return new int[] { };
            return ds.ToArray();
        }
        public bool IsCycle(List<List<int>> adj, int v, bool[] visited, List<int> dds)
        {

            visited[v] = true;
            foreach (int element in adj[v])
            {
                if (dds.Contains(v))
                    return true;
                dds.Add(v);
                if (!visited[element])
                 {
                    IsCycle(adj, element, visited, dds);
                 }
            }
            visited[v] = false;
            dds.Remove(v);
            return false;
        }
        public void dfs(List<List<int>> adj, int v, bool[] visited, Stack<int> ds)
        {

            if (visited[v]) return;
            visited[v] = true;
            foreach (int c in adj[v])
            {
                dfs(adj, c, visited, ds);
            }
            visited[v] = false;
            ds.Push(v);
        }
    }
}
