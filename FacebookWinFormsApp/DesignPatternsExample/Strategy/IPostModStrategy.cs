namespace BasicFacebookFeatures.DesignPatternsExample.Strategy
{
    public interface IPostModStrategy
    {
        string ModifyText(string i_Text,string i_Context);
    }
}