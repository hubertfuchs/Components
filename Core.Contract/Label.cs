namespace Fuchsbau.Components.CrossCutting.Core.Contract
{
    public abstract class Label
    {
        private string _text;

        public Label()
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
