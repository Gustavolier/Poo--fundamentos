using Balta.ContentConext.Enums;
using Balta.SharedConext;

namespace Balta.ContentConext
{
    public class Lecture : Base
    {
        public int Ordem { get; set; }

        public string Title { get; set; }

        public int DurationInMinutes { get; set; }
        public EcontentLevel Level { get; set; }
    }
}
