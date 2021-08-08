namespace Fuchsbau.Components.CrossCutting.Core.Contract
{
    public abstract class TextBox
    {
        private string _text;

        public TextBox()
        {
            _text = string.Empty;
        }

        public virtual string Text
        {
            get { return _text; }
            set { _text = value; }
        }
    }
}
