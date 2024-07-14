namespace String_Encode_and_Decode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Input = new List<string>{};
         
        }
        public static string Encode00(List<string> strs)
        {
            string OutString=string.Join(',',strs);

            return OutString.Trim(',');
        }
        public static List<string> Decode00(string s)
        {
            var result= s.Split(',').ToList();
            return result;
        }
        public static string Encode01(List<string> strs)
        {
            return string.Concat(strs.SelectMany(x =>$"{x.Length}#{x}"));
        }

        public static List<string> Decode01(string s)
        {
           var result=new List<string>();
            int i = 0;
            while(i < s.Length)
            {
                var j = i;
                while (s[j] != '#')
                {
                    j++;
                }
                int.TryParse(s.Substring(i,j-i), out var len);//to trun length and determine it to an (int)
                j++;
                result.Add(s.Substring(j,len));
                i = j+len;
            }
            return result;
        }
    }
}