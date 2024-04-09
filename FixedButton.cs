namespace MauiIosButtonFonts
{
    public class FixedButton : Button
    {
        protected override void OnHandlerChanged()
        {
            base.OnHandlerChanged();

            // UNCOMMENT TO FIX

            /*
            var x = this.CharacterSpacing;
            this.CharacterSpacing = 0;
            this.CharacterSpacing = x;
            */
        }
    }
}
