namespace Design_Patterns_Assignment
{
    public class BaseText : IBaseText
    {
        public string StartTag { get; set; }
        public string EndTag { get; set; }
        public BaseText()
        {
            StartTag = "";
            EndTag = "";
        }

        public string GetStartTag()
        {
            return StartTag;
        }

        public string GetEndTag()
        {
            return EndTag;
        }
    }
}