namespace KomunYslugi.Data
{
    public class DesignerData
    {
        public string content { get; set; }
        public string value { get; set; }
        public bool isCheck { get; set; } = false;
        public DesignerData (string content, string value)
        {
            this.content = content;
            this.value = value;
        }
    }
}
