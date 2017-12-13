namespace TechTalk.JiraRestClient
{
    public class RenderedFields
    {
        public RenderedFields()
        {
            description = "";
            comment= new CommentsContainer();
        }

        public string description { get; set; }
        public CommentsContainer comment { get; set; }
    }
}