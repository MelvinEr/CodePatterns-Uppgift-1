namespace Design_Patterns_Assignment
{
    public class SuperScript : TextDecorator, ISuperScript
    {
        public SuperScript(IText text) : base(text)
        {
            string start = "<sup>";
            string end = "</sup>";
            StartTag = start;
            EndTag = end;
        }
    }
}
